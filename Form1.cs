// This was written by me.
using PomodoroProject.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PomodoroProject 
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Counters
        int MinutesCounter, SecondesCounter = 0 ,BarMaximum ,TodayWork=0 ,
            PomoLengthCounter, ShortBreakCounter, LongBreakCounter, LongBreakAfterCounter; 

        // TimerStrings
        string Minutes, Seconds;

        // Sounnds
        SoundPlayer ClockSound = new SoundPlayer(@"trikc1.wav");
        SoundPlayer NotifySound = new SoundPlayer(@"NotifySound.wav");
        
        //((Form Load))
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Default Pomodoro settings
            cbPomoLength.SelectedIndex = 5;
            cbShortBreakLength.SelectedIndex = 4;
            cbLongBreakLength.SelectedIndex = 3;
            cbLongBreakAfter.SelectedIndex = 2;

            MinutesCounter = 30;
            PomoLengthCounter = 30;
            ShortBreakCounter = 5;
            LongBreakCounter = 20;
            LongBreakAfterCounter = 4;
            BarMaximum = 30 * 60;

            // Default Apperance settings
            rbONsound.Checked = true;
            rbOnDark.Checked = true;
            rbOnMessage.Checked = true;

            if (chkTasksList.Items.Count == 0)
                lblListisEmpty.Visible = true;

            // Default(first) Screen : (Focus)
            pnlFocus.Visible = true;
            pnlSettings.Visible = false;
            btnSettings.BackColor = ButtonNotSelected;
            btnFocus.BackColor = ButtonSelected;
        }


        //-------------------------------------------------------------------
        //((Edit Panels Theme(COLORS)))
        Color ButtonSelected = Color.FromArgb(80, 80, 80);
        Color ButtonNotSelected = Color.Transparent;
        Color LightBackground = Color.White;
        Color Light = Color.FromName("gradientinactivecaption");
        Color Dark = Color.Black;
        Color Brown = Color.FromArgb(64, 64, 64);

        private void UpdateRadioButtonsForecolor(GroupBox gb)
        {
            foreach(Control control in gb.Controls)
            {
                if (control is RadioButton rb)
                {
                    rb.ForeColor = gb.ForeColor;
                }
            }
        }
        private void FocusTheme(bool IsDark)
        {
            if(IsDark)
            {
                pnlFocus.BackColor = Dark;
                lblTimer.ForeColor = Light;
                lblMessage.ForeColor = Light;
            }
            else
            {
                pnlFocus.BackColor = LightBackground;
                lblTimer.ForeColor = Dark;
                lblMessage.ForeColor = Dark;
            }
        }
        private void DataListTheme(bool IsDark)
        {
            if(IsDark)
            {
                lblTodayWork.ForeColor = Light;
                lblTodayWorkValue.ForeColor = Light;
                lblTellNoDataBase.ForeColor = Light;
            }
            else
            {
                lblTodayWork.ForeColor = Dark;
                lblTodayWorkValue.ForeColor = Dark;
                lblTellNoDataBase.ForeColor = Dark;
            }
        }
        private void AboutTheme(bool IsDark)
        {
            if (IsDark)
            {
                lblBdawyAhmed.ForeColor = Light;
                lblDeveloperDefinition.ForeColor = Light;
            }
            else
            {
                lblBdawyAhmed.ForeColor = Dark;
                lblDeveloperDefinition.ForeColor = Dark;
            }
        }
        private void TasksTheme(bool IsDark)
        {
            if(IsDark)
            {
                chkTasksList.BackColor = Dark;
                chkTasksList.ForeColor = Light;
                btnAddTask.ForeColor = Light;
                lblListisEmpty.ForeColor = Light;
            }
            else
            {
                chkTasksList.BackColor = LightBackground;
                chkTasksList.ForeColor = Dark;
                btnAddTask.ForeColor = Dark;
                lblListisEmpty.ForeColor = Dark;
            }
        }
        private void SettingsTheme(bool IsDark)
        {
            if(IsDark)
            {
                pnlSettings.BackColor = Dark;
                lblPomoLength.ForeColor = Light;
                lblShortBreakLength.ForeColor = Light;
                lblLongBreakLength.ForeColor = Light;
                lblLongBreakaAfter.ForeColor = Light;
                btnPomoSettings.ForeColor = Light;
                btnApperanceSttings.ForeColor = Light;
                gbDarkMode.ForeColor = Light;
                gbFocusBackground.ForeColor = Light;
                gbInspirationSettings.ForeColor = Light;
                gbTickSound.ForeColor = Light;
                UpdateRadioButtonsForecolor(gbTickSound);
                UpdateRadioButtonsForecolor(gbDarkMode);
                UpdateRadioButtonsForecolor(gbFocusBackground);
                UpdateRadioButtonsForecolor(gbInspirationSettings);

                lblEditInspirationMsg.ForeColor = Light;
                btnChangeMsgFont.ForeColor = Light;
                btnApplayChangeMsg.ForeColor = Light;

                btnCustomSettings.ForeColor = Light;
                btnMenuBackgroundColorSettings.ForeColor = Light;
                btnMenuFontColorSettings.ForeColor = Light;
                btnMsgTimerColor.ForeColor = Light;
            }
            else
            {
                pnlSettings.BackColor = LightBackground;
                lblPomoLength.ForeColor = Dark;
                lblShortBreakLength.ForeColor = Dark;
                lblLongBreakLength.ForeColor = Dark;
                lblLongBreakaAfter.ForeColor = Dark;
                btnPomoSettings.ForeColor = Dark;
                btnApperanceSttings.ForeColor = Dark;
                gbDarkMode.ForeColor = Dark;
                gbFocusBackground.ForeColor = Dark;
                gbInspirationSettings.ForeColor = Dark;
                gbTickSound.ForeColor = Dark;
                UpdateRadioButtonsForecolor(gbTickSound);
                UpdateRadioButtonsForecolor(gbDarkMode);
                UpdateRadioButtonsForecolor(gbFocusBackground);
                UpdateRadioButtonsForecolor(gbInspirationSettings);

                lblEditInspirationMsg.ForeColor = Dark;
                btnChangeMsgFont.ForeColor = Dark;
                btnApplayChangeMsg.ForeColor = Dark;

                btnCustomSettings.ForeColor = Dark;
                btnMenuBackgroundColorSettings.ForeColor = Dark;
                btnMenuFontColorSettings.ForeColor = Dark;
                btnMsgTimerColor.ForeColor = Dark;
            }
        }
        private void LeftSideTheme(bool IsDark)
        {
            Color DarkBackground = Color.FromArgb(64, 64, 64);
            Color LightBackground = Color.FromName("gainsboro");

            if (IsDark)
            {
                pnlLeftSide.BackColor = DarkBackground;
                btnFocus.ForeColor = Light;
                btnSettings.ForeColor = Light;
                btnTasks.ForeColor = Light;
                btnDataList.ForeColor = Light;
                btnAbout.ForeColor = Light;
                lblMenu.ForeColor = Light;
            }
            else
            {
                pnlLeftSide.BackColor = LightBackground;
                btnFocus.ForeColor = Dark;
                btnSettings.ForeColor = Dark;
                btnTasks.ForeColor = Dark;
                btnDataList.ForeColor = Dark;
                btnAbout.ForeColor = Dark;
                lblMenu.ForeColor = Dark;
            }
        }
        private void UpdateProgramTheme(bool IsDark)
        {
            FocusTheme(IsDark);
            SettingsTheme(IsDark);
            LeftSideTheme(IsDark);
            TasksTheme(IsDark);
            DataListTheme(IsDark);
            AboutTheme(IsDark);
        }
        private void TimerMessageColor(Color c)
        {
            lblTimer.ForeColor =c;
            lblMessage.ForeColor =c;
        }


        //((Edit Bar progress))
        private void SetBarLength(int maximum)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = maximum * 60 ; 
        }

        //(NotifyIcon) 
        private void Notification(string mode)  
        {
            string title = "", message = "";

            if (mode == "short")
            {
                title = "Good Work 💪";
                message = "Take your break without Phone 😊";
            }
            else if (mode == "work")
            {
                title = "It's work time 🕘";
                message = "Let's to continue our journey towards the goal";
            }
            else if (mode == "long")
            {
                title = "Great Work 💪";
                message = "You have finished " + (cbLongBreakAfter.SelectedIndex + 2) + " intervals🥇\nNow you deserve a deep break 💙";
            }


            notifyIcon1.Icon = new System.Drawing.Icon(@"PomoIcon.ico");
            notifyIcon1.Text = "PomBdawy";
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.ShowBalloonTip(15000);

        }
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            NotifySound.Stop();
            this.Show();
        }
        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            NotifySound.Stop();
        }
        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {
            NotifySound.Play();
        }


        //-------------------------------------------------------------------  
        // ((Left Side Buttons))
        private void SelectedButton(Control pnl, Control btn)
        {
            ButtonSelected = Color.FromArgb(80, 80, 80);
            if (rbOffDark.Checked)
                ButtonSelected = Color.Silver;

            foreach (Control c in pnl.Controls)
            {
                if (c == btn)
                    c.BackColor = ButtonSelected;
                else
                    c.BackColor = Color.Transparent;
            }

        }
        private void btnFocus_Click(object sender, EventArgs e)
        {
            pnlFocus.Visible = true;
            pnlSettings.Visible = false;

            SelectedButton(pnlLeftSide,btnFocus);
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlFocus.Visible = true;
            pnlSettings.Visible = true;
            pnlTasksTop.Visible = true;
            pnlTasksBottom.Visible = true;
            pnlDataListTop.Visible = true;
            pnlDataListBottom.Visible = true;
            pnlAbout.Visible = true;
            pnlPomoSettings.Visible = true;
            pnlApperanceSettings.Visible = true;
            pnlCustomSettings.Visible = true;
            pnlInnerSeetings.Visible = true;
            pnlAbout.Visible = true;
            SelectedButton(pnlLeftSide, btnAbout);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {

            pnlSettings.Visible = true;
            pnlApperanceSettings.Visible = false;
            pnlTasksTop.Visible = false;
            pnlTasksBottom.Visible = false;
            SelectedButton(pnlLeftSide, btnSettings);

            btnPomoSettings.BackColor = ButtonSelected;
            btnCustomSettings.BackColor = ButtonNotSelected;
            btnApperanceSttings.BackColor = ButtonNotSelected;
        }
        private void btnDataList_Click(object sender, EventArgs e)
        {
            pnlFocus.Visible = true;
            pnlSettings.Visible = true;
            pnlInnerSeetings.Visible = true;
            pnlPomoSettings.Visible = true;
            pnlApperanceSettings.Visible = true;
            pnlCustomSettings.Visible = true;
            pnlTasksTop.Visible = true;
            pnlTasksBottom.Visible = true;
            pnlDataListBottom.Visible = true;
            pnlDataListTop.Visible = true;
            pnlAbout.Visible = false;
            SelectedButton(pnlLeftSide, btnDataList);

        }
        private void btnTasks_Click(object sender, EventArgs e)
        {
            pnlTasksTop.Visible = true;
            pnlTasksBottom.Visible = true;
            pnlFocus.Visible = true;
            pnlSettings.Visible = true;
            pnlInnerSeetings.Visible = true;
            pnlPomoSettings.Visible = true;
            pnlApperanceSettings.Visible = true;
            pnlCustomSettings.Visible = true;
            pnlDataListBottom.Visible = false;
            pnlDataListTop.Visible = false;
            SelectedButton(pnlLeftSide, btnTasks);
        }



        //-------------------------------------------------------------------
        //((Focus Screen))
        private void UpdateTodayWork()
        {
            TodayWork += PomoLengthCounter;
            if (TodayWork <= 9)
                lblTodayWorkValue.Text = "0" + TodayWork;
            else
                lblTodayWorkValue.Text = TodayWork.ToString();
        }
        private void btnVolum_Click(object sender, EventArgs e)
        {
            if (btnVolum.Tag == "0")
            {
                ClockSound.SoundLocation = @"Mute.wav";
                btnVolum.BackgroundImage = Resources.Mute;
                btnVolum.Tag = "1";
            }
            else
            {
                ClockSound.SoundLocation = @"trikc1.wav";
                btnVolum.BackgroundImage = Resources.Volum;
                btnVolum.Tag = "0";
            }
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            progressBar1.Value = 0;
            btnPlay.Tag = "0";
            btnPlay.BackgroundImage = Resources.play;

            if(PomoLengthCounter < 10)
                lblTimer.Text = "0"+ PomoLengthCounter.ToString() + ":00";
            else
                lblTimer.Text = PomoLengthCounter.ToString() + ":00";

            MinutesCounter = PomoLengthCounter;
            SecondesCounter = 0;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Tag == "1")
            {
                btnPlay.Tag = "0";
                btnPlay.BackgroundImage = Resources.play;
                timer1.Enabled = false;
            }
            else
            {
                btnPlay.Tag = "1";
                btnPlay.BackgroundImage = Resources.pause;
                timer1.Enabled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockSound.Play();

            if(progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value++;

            if (SecondesCounter == 0 )
            {
                MinutesCounter--;

                if (MinutesCounter == -1 )
                {
                    timer1.Enabled = false;
                    SecondesCounter = 0;
                    btnPlay.Tag = "0";
                    btnPlay.BackgroundImage = Resources.play;
                    Notification(timer1.Tag.ToString());



                    if (timer1.Tag == "short" )
                    {
                        UpdateTodayWork();

                        LongBreakAfterCounter--;

                        MinutesCounter = ShortBreakCounter;
                        SetBarLength(MinutesCounter);
                        timer1.Tag = "work";
                    }
                    else if (timer1.Tag == "work" )
                    {
                        MinutesCounter = PomoLengthCounter;
                        SetBarLength(MinutesCounter);

                        if (LongBreakAfterCounter == 1)
                            timer1.Tag = "long";
                        else
                            timer1.Tag = "short";
                    }
                    else if (timer1.Tag == "long") 
                    {
                        UpdateTodayWork();

                        LongBreakAfterCounter = cbLongBreakAfter.SelectedIndex + 2;
                        MinutesCounter = LongBreakCounter;
                        SetBarLength(MinutesCounter);
                        timer1.Tag = "work";
                    }
                }
                else
                {
                    SecondesCounter = 59;
                }
            }
            else
                SecondesCounter--;
            
            Minutes = MinutesCounter.ToString();
            Seconds = SecondesCounter.ToString();

            if (MinutesCounter <= 9)
                Minutes = "0" + Minutes;

            if (SecondesCounter <= 9)
                Seconds = "0" + Seconds;

            lblTimer.Text= Minutes + ":" + Seconds;
        }




        //-------------------------------------------------------------------
        //((Settings Screen))
        // Pomodoro Settings------------
        private void WarningLoseCurrentInterval(object sender, EventArgs e)
        {
            if (timer1.Enabled == true )
            {
                if (MessageBox.Show("You will lose the current interval Are you sure? ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning ,MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    timer1.Enabled = false;
                    btnPlay.Tag = "0";
                    btnPlay.BackgroundImage = Resources.play;

                    if (PomoLengthCounter < 10)
                        lblTimer.Text = "05:00";
                    else
                        lblTimer.Text = PomoLengthCounter.ToString() + ":00";

                    SecondesCounter = 0;

                    progressBar1.Value = 0;
                }
            }
        }
        private void btnPomoSettings_Click(object sender, EventArgs e)
        {
            SelectedButton(pnlInnerSeetings, btnPomoSettings);

            pnlApperanceSettings.Visible = false;
            pnlCustomSettings.Visible = false;
        }
        private void cbPomoLength_SelectedIndexChanged(object sender, EventArgs e)
        {

            int x = (cbPomoLength.SelectedIndex + 1) * 5;
            SecondesCounter = 0;
            PomoLengthCounter = x;
            MinutesCounter = x;
            SetBarLength(x);

            if (x < 10)
                lblTimer.Text = "05:00";
            else
                lblTimer.Text = x.ToString() + ":00";
        }
        private void cbShortBreakLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShortBreakCounter = cbShortBreakLength.SelectedIndex + 1;
        }
        private void cbLongBreakLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            LongBreakCounter = (cbLongBreakLength.SelectedIndex + 1) * 5;
        }
        private void cbLongBreakAfter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LongBreakAfterCounter = cbLongBreakAfter.SelectedIndex + 2;
        }
        // Apperance Settings------------
        private void btnApperanceSttings_Click(object sender, EventArgs e)
        {
            SelectedButton(pnlInnerSeetings, btnApperanceSttings);


            pnlCustomSettings.Visible = false;
            pnlApperanceSettings.Visible = true;
        }
        // (On ,Off message)---
        private void rbOnMessage_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
        }
        private void rbOffMessage_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        // (On ,Off DarkMode)---
        private void rbOnDark_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgramTheme(true);
            SelectedButton(pnlLeftSide,btnSettings);
            SelectedButton(pnlInnerSeetings,btnApperanceSttings);
        }
        private void rbOffDark_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgramTheme(false);
            SelectedButton(pnlLeftSide, btnSettings);
            SelectedButton(pnlInnerSeetings, btnApperanceSttings);
        }

        // (On ,Off Sound)---
        private void rbOnSound_CheckedChanged(object sender, EventArgs e)
        {
            ClockSound.SoundLocation = @"trikc1.wav";
            btnVolum.BackgroundImage = Resources.Volum;
            btnVolum.Tag = "0";
        }
        private void rbOffSound_CheckedChanged(object sender, EventArgs e)
        {
            ClockSound.SoundLocation = @"Mute.wav";
            btnVolum.BackgroundImage = Resources.Mute;
            btnVolum.Tag = "1";
        }

        // (BackGround)----
        private void rbGalaxy_CheckedChanged(object sender, EventArgs e)
        {
            pnlFocus.BackgroundImage = Resources.Galaxy;
            LeftSideTheme(true);
            TimerMessageColor(Light);
        }
        private void rbProgramming_CheckedChanged(object sender, EventArgs e)
        {
            pnlFocus.BackgroundImage = Resources.Programmin;
            LeftSideTheme(true);
            TimerMessageColor(Light);
        }
        private void rbBlackSands_CheckedChanged(object sender, EventArgs e)
        {
            pnlFocus.BackgroundImage = Resources.BlackSands;
            LeftSideTheme(true);
            TimerMessageColor(Light);
        }
        private void rbMountain_CheckedChanged(object sender, EventArgs e)
        {
            pnlFocus.BackgroundImage = Resources.Mountain;
            LeftSideTheme(true);
            TimerMessageColor(Light);
        }
        private void rbLightForest_CheckedChanged(object sender, EventArgs e)
        {
            pnlFocus.BackgroundImage = Resources.LightForest;
            LeftSideTheme(true);
            TimerMessageColor(Brown);
        }
        private void rbDarkForest_CheckedChanged(object sender, EventArgs e)
        {
            pnlFocus.BackgroundImage = Resources.DarkForest;
            LeftSideTheme(true);
            TimerMessageColor(Light);
        }
        private void rbLightRoad_CheckedChanged(object sender, EventArgs e)
        {
            pnlFocus.BackgroundImage = Resources.LightRoad;
            LeftSideTheme(true);
            TimerMessageColor(Light);
        }
        private void rbDarkRoad_CheckedChanged(object sender, EventArgs e)
        {
            pnlFocus.BackgroundImage = Resources.DarkRoad;
            LeftSideTheme(true);
            TimerMessageColor(Light);
        }

        // Custom Settings------------
        private void btnCustomSettings_Click(object sender, EventArgs e)
        {
            SelectedButton(pnlInnerSeetings, btnCustomSettings);


            pnlApperanceSettings.Visible = true;
            pnlCustomSettings.Visible = true;

        }

        // (Inspir message)----
        private void btnApplayChangeMsg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInspiratinomsg.Text))
            {
                lblMessage.Text = txtInspiratinomsg.Text;
                lblMessage.AutoSize = false;
                lblMessage.TextAlign = ContentAlignment.TopCenter;
                lblMessage.Dock = DockStyle.None;
                lblMessage.Anchor = AnchorStyles.Top;
                lblMessage.Width = pnlFocus.Width;
                lblMessage.Location = new Point((pnlFocus.Width - pnlFocus.Width) / 2, 0);
                lblMessage.Height = 150;

                MessageBox.Show("Message Updated to : " + lblMessage.Text, "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Empty Message ", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnChangeMsgFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;

            fontDialog1.Font = txtInspiratinomsg.Font;
            fontDialog1.Color = txtInspiratinomsg.ForeColor;

            Font OldFont = txtInspiratinomsg.Font;
            Color OldColor = txtInspiratinomsg.ForeColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lblMessage.Font = fontDialog1.Font;
                lblMessage.ForeColor = fontDialog1.Color;
                txtInspiratinomsg.Font = fontDialog1.Font;
                txtInspiratinomsg.ForeColor = fontDialog1.Color;
            }
            else
            {
                txtInspiratinomsg.Font = OldFont;
                txtInspiratinomsg.ForeColor = OldColor;
            }
        }
        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            txtInspiratinomsg.Font = fontDialog1.Font;
            txtInspiratinomsg.ForeColor = fontDialog1.Color;
        }

        // (Custom Colors)----
        private void btnMenuBackgroundColorSettings_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlLeftSide.BackColor = colorDialog1.Color;
                btnMenuBackgroundColorSettings.BackColor = colorDialog1.Color;
            }
        }
        private void btnMenuFontColorSettings_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnMenuFontColorSettings.ForeColor = colorDialog1.Color;
                btnFocus.ForeColor = colorDialog1.Color;
                btnSettings.ForeColor = colorDialog1.Color;
                btnTasks.ForeColor = colorDialog1.Color;
                btnDataList.ForeColor = colorDialog1.Color;
                btnAbout.ForeColor = colorDialog1.Color;
                lblMenu.ForeColor = colorDialog1.Color;
            }
        }
        private void btnMsgTimerColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnMsgTimerColor.ForeColor = colorDialog1.Color;
                lblTimer.ForeColor = colorDialog1.Color;
                lblMessage.ForeColor = colorDialog1.Color;
            }
        }


        //((Tasks Screen))
        //------------------------------------------------------------------
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWriteTask.Text))
            {
                chkTasksList.Items.Add(txtWriteTask.Text);
                txtWriteTask.Clear();
                lblListisEmpty.Visible = false;
            }

        }
        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = chkTasksList.SelectedIndex;

            if (selectedIndex != -1)
                chkTasksList.SetItemChecked(selectedIndex, true);
        }
        private void unCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = chkTasksList.SelectedIndex;

            if (selectedIndex != -1)
                chkTasksList.SetItemChecked(selectedIndex, false);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = chkTasksList.SelectedIndex;

            if (selectedIndex != -1)
                chkTasksList.Items.RemoveAt(selectedIndex);

            if (chkTasksList.Items.Count == 0)
                lblListisEmpty.Visible = true;
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkTasksList.SelectedItem != null)
            {
                string SelectedItem = chkTasksList.SelectedItem.ToString();

                int selectedIndex = chkTasksList.SelectedIndex;
                Rectangle itemRectangle = chkTasksList.GetItemRectangle(selectedIndex);
                Point screenPosition = chkTasksList.PointToScreen(new Point(itemRectangle.Left, itemRectangle.Bottom));

                frmEditTask frm = new frmEditTask(SelectedItem);
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = screenPosition;
                frm.ShowDialog();
            }
        }
        public void UpdateSelectedItem(string newItemName)
        {
            int selectedIndex = chkTasksList.SelectedIndex;
            chkTasksList.Items[selectedIndex] = newItemName;
        }
        private void chkTasksList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int selectedIndex = chkTasksList.SelectedIndex;

                if (selectedIndex != -1)
                {
                    if (chkTasksList.GetItemCheckState(selectedIndex) == CheckState.Unchecked)
                    {
                        unCheckToolStripMenuItem.Enabled = false;
                        CheckToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        CheckToolStripMenuItem.Enabled = false;
                        unCheckToolStripMenuItem.Enabled = true;
                    }
                }
            }
        }
        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkTasksList.Items.Count > 0)
            {
                if (MessageBox.Show("Are you Sure Delete All Tasks ? ", "Clear List", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    chkTasksList.Items.Clear();
                    lblListisEmpty.Visible = true;
                }
            }
        }


        //-------------------------------------------------------------------
        //((About Screen))
        private void linkLabelLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.linkedin.com/in/bdawyv7");
            linkLabelLinkedIn.LinkVisited = true;
        }
        private void linkLabelFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/bdawyv7");
            linkLabelFacebook.LinkVisited = true;
        }
        private void linkLabelYoutube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.youtube.com/@bdawyv7");
            linkLabelYoutube.LinkVisited = true;
        }
    }
}

       
