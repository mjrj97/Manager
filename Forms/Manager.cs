﻿using Timotheus.Schedule;
using Timotheus.Utility;
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Timotheus
{
    public partial class MainWindow : Form
    {
        public static MainWindow window;
        public List<Event> events = new List<Event>();
        public SortableBindingList<Event> shownEvents = new SortableBindingList<Event>();

        private int year;
        private readonly Calendar calendar;
        
        //Constructor
        public MainWindow()
        {
            window = this;
            year = DateTime.Now.Year;
            InitializeComponent();
            Year.Text = year.ToString();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullName = Path.Combine(desktopPath, "Data.txt");
            StreamReader steamReader = new StreamReader(fullName);
            string[] content = steamReader.ReadToEnd().Split("\n");
            steamReader.Close();
            
            calendar = new Calendar(content[0].Trim(), content[1].Trim(), content[2].Trim());
            calendar.GetEvents(events);
            UpdateTable();
            CalendarView.DataSource = new BindingSource(shownEvents, null);
        }

        public void AddEventToCalendar(Event ev)
        {
            events.Add(ev);
            UpdateTable();
        }

        //Update contents
        private void UpdateYear(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "+")
                year++;
            else if (button.Text == "-")
                year--;
            Year.Text = year.ToString();
            UpdateTable();
        }

        private void UpdateTable()
        {
            shownEvents.Clear();
            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].StartTime.Year == year && !events[i].Deleted)
                    shownEvents.Add(events[i]);
            }
            CalendarView.Sort(CalendarView.Columns[0], ListSortDirection.Ascending);
        }

        //Buttons
        private void Add_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent();
            addEvent.Owner = this;
            addEvent.ShowDialog();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (shownEvents.Count > 0)
            {
                Event ev = shownEvents[CalendarView.CurrentCell.OwningRow.Index];
                int index = 0;
                for (int i = 0; i < events.Count; i++)
                {
                    if (ev.Equals(events[i]))
                        index = i;
                }
                events[index].Deleted = true;
                UpdateTable();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "iCalendar files (*.ics)|*.ics";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    byte[] data = Encoding.UTF8.GetBytes(calendar.GetCalendarICS(Path.GetFileNameWithoutExtension(saveFileDialog.FileName), events));
                    stream.Write(data);
                    stream.Close();
                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenCalendar open = new OpenCalendar();
            open.Owner = this;
            open.ShowDialog();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportPDF(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Program for foråret 2021", events);
        }

        private void SyncCalendar(object sender, EventArgs e)
        {
            calendar.Sync(events);
            calendar.GetEvents(events);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None)
            {
                if (keyData == Keys.Delete && tabControl.SelectedIndex == 0)
                {
                    Remove_Click(null, null);
                    return true;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        //Help
        private void SourceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SourceLink.LinkVisited = true;
            Process p = new Process();
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = "/c start https://www.github.com/mjrj97/Manager";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
        }

        private void EmailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailLink.LinkVisited = true;
            Process p = new Process();
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = "/c start mailto:martin.jensen.1997@hotmail.com";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
        }

        //Tray icon
        private void Open(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            TrayIcon.Visible = false;
        }
        
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Manager_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                TrayIcon.Visible = true;
            }
        }

        public static void ExportPDF(string filePath, string title, List<Event> events)
        {

        }
    }
}