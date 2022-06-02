using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MMK_CS_2_SevenSegmentClock
{
    public partial class CS_SevenSegClock : Form
    {
        enum SevenSeg_Types
        {
            SecondDots,
            Hour1,
            Hour2,
            Minute1,
            Minute2,
            Second1,
            Second2
        }

        public CS_SevenSegClock()
        {
            InitializeComponent();
        }

        private void CS_SevenSegClock_Load(object sender, EventArgs e)
        {
            timer_Update.Enabled = true;
            timer_Update.Start();
        }

        private void timer_Update_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            
            if(timeNow.Millisecond < 500)
            {
                label_SEG_DOT_MS_1.BackColor = Color.DarkGreen;
                label_SEG_DOT_MS_2.BackColor = Color.DarkGreen;
            }
            else
            {
                label_SEG_DOT_MS_1.BackColor = Color.Lime;
                label_SEG_DOT_MS_2.BackColor = Color.Lime;
            }

            updateSevenSegments(timeNow);
        }

        private void updateSevenSegments(DateTime time)
        {
            int s2 = time.Second % 10;
            int s1 = (time.Second / 10) % 10;
            int m2 = time.Minute % 10;
            int m1 = (time.Minute / 10) % 10;
            int h2 = time.Hour % 10;
            int h1 = (time.Hour / 10) % 10;

            setSevenSegmentDisplay(s2, SevenSeg_Types.Second2);
            setSevenSegmentDisplay(s1, SevenSeg_Types.Second1);
            setSevenSegmentDisplay(m2, SevenSeg_Types.Minute2);
            setSevenSegmentDisplay(m1, SevenSeg_Types.Minute1);
            setSevenSegmentDisplay(h2, SevenSeg_Types.Hour2);
            setSevenSegmentDisplay(h1, SevenSeg_Types.Hour1);
        }

        private void setSevenSegmentDisplay(int n, SevenSeg_Types seg)
        {
            switch(seg)
            {
                case SevenSeg_Types.SecondDots:
                    break;

                case SevenSeg_Types.Hour1:

                    switch(n)
                    {
                        case 0:
                            label_SEG_H1_A.BackColor = Color.Lime;
                            label_SEG_H1_B.BackColor = Color.Lime;
                            label_SEG_H1_C.BackColor = Color.Lime;
                            label_SEG_H1_D.BackColor = Color.Lime;
                            label_SEG_H1_E.BackColor = Color.Lime;
                            label_SEG_H1_F.BackColor = Color.Lime;
                            label_SEG_H1_G.BackColor = Color.DarkGreen;
                            break;

                        case 1:
                            label_SEG_H1_A.BackColor = Color.DarkGreen;
                            label_SEG_H1_B.BackColor = Color.Lime;
                            label_SEG_H1_C.BackColor = Color.Lime;
                            label_SEG_H1_D.BackColor = Color.DarkGreen;
                            label_SEG_H1_E.BackColor = Color.DarkGreen;
                            label_SEG_H1_F.BackColor = Color.DarkGreen;
                            label_SEG_H1_G.BackColor = Color.DarkGreen;
                            break;

                        case 2:
                            label_SEG_H1_A.BackColor = Color.Lime;
                            label_SEG_H1_B.BackColor = Color.Lime;
                            label_SEG_H1_C.BackColor = Color.DarkGreen;
                            label_SEG_H1_D.BackColor = Color.Lime;
                            label_SEG_H1_E.BackColor = Color.Lime;
                            label_SEG_H1_F.BackColor = Color.DarkGreen;
                            label_SEG_H1_G.BackColor = Color.Lime;
                            break;

                        case 3:
                            label_SEG_H1_A.BackColor = Color.Lime;
                            label_SEG_H1_B.BackColor = Color.Lime;
                            label_SEG_H1_C.BackColor = Color.Lime;
                            label_SEG_H1_D.BackColor = Color.Lime;
                            label_SEG_H1_E.BackColor = Color.DarkGreen;
                            label_SEG_H1_F.BackColor = Color.DarkGreen;
                            label_SEG_H1_G.BackColor = Color.Lime;
                            break;

                        case 4:
                            label_SEG_H1_A.BackColor = Color.DarkGreen;
                            label_SEG_H1_B.BackColor = Color.Lime;
                            label_SEG_H1_C.BackColor = Color.Lime;
                            label_SEG_H1_D.BackColor = Color.DarkGreen;
                            label_SEG_H1_E.BackColor = Color.DarkGreen;
                            label_SEG_H1_F.BackColor = Color.Lime;
                            label_SEG_H1_G.BackColor = Color.Lime;
                            break;

                        case 5:
                            label_SEG_H1_A.BackColor = Color.Lime;
                            label_SEG_H1_B.BackColor = Color.DarkGreen;
                            label_SEG_H1_C.BackColor = Color.Lime;
                            label_SEG_H1_D.BackColor = Color.Lime;
                            label_SEG_H1_E.BackColor = Color.DarkGreen;
                            label_SEG_H1_F.BackColor = Color.Lime;
                            label_SEG_H1_G.BackColor = Color.Lime;
                            break;

                        case 6:
                            label_SEG_H1_A.BackColor = Color.Lime;
                            label_SEG_H1_B.BackColor = Color.DarkGreen;
                            label_SEG_H1_C.BackColor = Color.Lime;
                            label_SEG_H1_D.BackColor = Color.Lime;
                            label_SEG_H1_E.BackColor = Color.Lime;
                            label_SEG_H1_F.BackColor = Color.Lime;
                            label_SEG_H1_G.BackColor = Color.Lime;
                            break;

                        case 7:
                            label_SEG_H1_A.BackColor = Color.Lime;
                            label_SEG_H1_B.BackColor = Color.Lime;
                            label_SEG_H1_C.BackColor = Color.Lime;
                            label_SEG_H1_D.BackColor = Color.DarkGreen;
                            label_SEG_H1_E.BackColor = Color.DarkGreen;
                            label_SEG_H1_F.BackColor = Color.DarkGreen;
                            label_SEG_H1_G.BackColor = Color.DarkGreen;
                            break;

                        case 8:
                            label_SEG_H1_A.BackColor = Color.Lime;
                            label_SEG_H1_B.BackColor = Color.Lime;
                            label_SEG_H1_C.BackColor = Color.Lime;
                            label_SEG_H1_D.BackColor = Color.Lime;
                            label_SEG_H1_E.BackColor = Color.Lime;
                            label_SEG_H1_F.BackColor = Color.Lime;
                            label_SEG_H1_G.BackColor = Color.Lime;
                            break;

                        case 9:
                            label_SEG_H1_A.BackColor = Color.Lime;
                            label_SEG_H1_B.BackColor = Color.Lime;
                            label_SEG_H1_C.BackColor = Color.Lime;
                            label_SEG_H1_D.BackColor = Color.Lime;
                            label_SEG_H1_E.BackColor = Color.DarkGreen;
                            label_SEG_H1_F.BackColor = Color.Lime;
                            label_SEG_H1_G.BackColor = Color.Lime;
                            break;
                    }

                    break;

                case SevenSeg_Types.Hour2:

                    switch (n)
                    {
                        case 0:
                            label_SEG_H2_A.BackColor = Color.Lime;
                            label_SEG_H2_B.BackColor = Color.Lime;
                            label_SEG_H2_C.BackColor = Color.Lime;
                            label_SEG_H2_D.BackColor = Color.Lime;
                            label_SEG_H2_E.BackColor = Color.Lime;
                            label_SEG_H2_F.BackColor = Color.Lime;
                            label_SEG_H2_G.BackColor = Color.DarkGreen;
                            break;

                        case 1:
                            label_SEG_H2_A.BackColor = Color.DarkGreen;
                            label_SEG_H2_B.BackColor = Color.Lime;
                            label_SEG_H2_C.BackColor = Color.Lime;
                            label_SEG_H2_D.BackColor = Color.DarkGreen;
                            label_SEG_H2_E.BackColor = Color.DarkGreen;
                            label_SEG_H2_F.BackColor = Color.DarkGreen;
                            label_SEG_H2_G.BackColor = Color.DarkGreen;
                            break;

                        case 2:
                            label_SEG_H2_A.BackColor = Color.Lime;
                            label_SEG_H2_B.BackColor = Color.Lime;
                            label_SEG_H2_C.BackColor = Color.DarkGreen;
                            label_SEG_H2_D.BackColor = Color.Lime;
                            label_SEG_H2_E.BackColor = Color.Lime;
                            label_SEG_H2_F.BackColor = Color.DarkGreen;
                            label_SEG_H2_G.BackColor = Color.Lime;
                            break;

                        case 3:
                            label_SEG_H2_A.BackColor = Color.Lime;
                            label_SEG_H2_B.BackColor = Color.Lime;
                            label_SEG_H2_C.BackColor = Color.Lime;
                            label_SEG_H2_D.BackColor = Color.Lime;
                            label_SEG_H2_E.BackColor = Color.DarkGreen;
                            label_SEG_H2_F.BackColor = Color.DarkGreen;
                            label_SEG_H2_G.BackColor = Color.Lime;
                            break;

                        case 4:
                            label_SEG_H2_A.BackColor = Color.DarkGreen;
                            label_SEG_H2_B.BackColor = Color.Lime;
                            label_SEG_H2_C.BackColor = Color.Lime;
                            label_SEG_H2_D.BackColor = Color.DarkGreen;
                            label_SEG_H2_E.BackColor = Color.DarkGreen;
                            label_SEG_H2_F.BackColor = Color.Lime;
                            label_SEG_H2_G.BackColor = Color.Lime;
                            break;

                        case 5:
                            label_SEG_H2_A.BackColor = Color.Lime;
                            label_SEG_H2_B.BackColor = Color.DarkGreen;
                            label_SEG_H2_C.BackColor = Color.Lime;
                            label_SEG_H2_D.BackColor = Color.Lime;
                            label_SEG_H2_E.BackColor = Color.DarkGreen;
                            label_SEG_H2_F.BackColor = Color.Lime;
                            label_SEG_H2_G.BackColor = Color.Lime;
                            break;

                        case 6:
                            label_SEG_H2_A.BackColor = Color.Lime;
                            label_SEG_H2_B.BackColor = Color.DarkGreen;
                            label_SEG_H2_C.BackColor = Color.Lime;
                            label_SEG_H2_D.BackColor = Color.Lime;
                            label_SEG_H2_E.BackColor = Color.Lime;
                            label_SEG_H2_F.BackColor = Color.Lime;
                            label_SEG_H2_G.BackColor = Color.Lime;
                            break;

                        case 7:
                            label_SEG_H2_A.BackColor = Color.Lime;
                            label_SEG_H2_B.BackColor = Color.Lime;
                            label_SEG_H2_C.BackColor = Color.Lime;
                            label_SEG_H2_D.BackColor = Color.DarkGreen;
                            label_SEG_H2_E.BackColor = Color.DarkGreen;
                            label_SEG_H2_F.BackColor = Color.DarkGreen;
                            label_SEG_H2_G.BackColor = Color.DarkGreen;
                            break;

                        case 8:
                            label_SEG_H2_A.BackColor = Color.Lime;
                            label_SEG_H2_B.BackColor = Color.Lime;
                            label_SEG_H2_C.BackColor = Color.Lime;
                            label_SEG_H2_D.BackColor = Color.Lime;
                            label_SEG_H2_E.BackColor = Color.Lime;
                            label_SEG_H2_F.BackColor = Color.Lime;
                            label_SEG_H2_G.BackColor = Color.Lime;
                            break;

                        case 9:
                            label_SEG_H2_A.BackColor = Color.Lime;
                            label_SEG_H2_B.BackColor = Color.Lime;
                            label_SEG_H2_C.BackColor = Color.Lime;
                            label_SEG_H2_D.BackColor = Color.Lime;
                            label_SEG_H2_E.BackColor = Color.DarkGreen;
                            label_SEG_H2_F.BackColor = Color.Lime;
                            label_SEG_H2_G.BackColor = Color.Lime;
                            break;
                    }

                    break;

                case SevenSeg_Types.Minute1:

                    switch (n)
                    {
                        case 0:
                            label_SEG_M1_A.BackColor = Color.Lime;
                            label_SEG_M1_B.BackColor = Color.Lime;
                            label_SEG_M1_C.BackColor = Color.Lime;
                            label_SEG_M1_D.BackColor = Color.Lime;
                            label_SEG_M1_E.BackColor = Color.Lime;
                            label_SEG_M1_F.BackColor = Color.Lime;
                            label_SEG_M1_G.BackColor = Color.DarkGreen;
                            break;

                        case 1:
                            label_SEG_M1_A.BackColor = Color.DarkGreen;
                            label_SEG_M1_B.BackColor = Color.Lime;
                            label_SEG_M1_C.BackColor = Color.Lime;
                            label_SEG_M1_D.BackColor = Color.DarkGreen;
                            label_SEG_M1_E.BackColor = Color.DarkGreen;
                            label_SEG_M1_F.BackColor = Color.DarkGreen;
                            label_SEG_M1_G.BackColor = Color.DarkGreen;
                            break;

                        case 2:
                            label_SEG_M1_A.BackColor = Color.Lime;
                            label_SEG_M1_B.BackColor = Color.Lime;
                            label_SEG_M1_C.BackColor = Color.DarkGreen;
                            label_SEG_M1_D.BackColor = Color.Lime;
                            label_SEG_M1_E.BackColor = Color.Lime;
                            label_SEG_M1_F.BackColor = Color.DarkGreen;
                            label_SEG_M1_G.BackColor = Color.Lime;
                            break;

                        case 3:
                            label_SEG_M1_A.BackColor = Color.Lime;
                            label_SEG_M1_B.BackColor = Color.Lime;
                            label_SEG_M1_C.BackColor = Color.Lime;
                            label_SEG_M1_D.BackColor = Color.Lime;
                            label_SEG_M1_E.BackColor = Color.DarkGreen;
                            label_SEG_M1_F.BackColor = Color.DarkGreen;
                            label_SEG_M1_G.BackColor = Color.Lime;
                            break;

                        case 4:
                            label_SEG_M1_A.BackColor = Color.DarkGreen;
                            label_SEG_M1_B.BackColor = Color.Lime;
                            label_SEG_M1_C.BackColor = Color.Lime;
                            label_SEG_M1_D.BackColor = Color.DarkGreen;
                            label_SEG_M1_E.BackColor = Color.DarkGreen;
                            label_SEG_M1_F.BackColor = Color.Lime;
                            label_SEG_M1_G.BackColor = Color.Lime;
                            break;

                        case 5:
                            label_SEG_M1_A.BackColor = Color.Lime;
                            label_SEG_M1_B.BackColor = Color.DarkGreen;
                            label_SEG_M1_C.BackColor = Color.Lime;
                            label_SEG_M1_D.BackColor = Color.Lime;
                            label_SEG_M1_E.BackColor = Color.DarkGreen;
                            label_SEG_M1_F.BackColor = Color.Lime;
                            label_SEG_M1_G.BackColor = Color.Lime;
                            break;

                        case 6:
                            label_SEG_M1_A.BackColor = Color.Lime;
                            label_SEG_M1_B.BackColor = Color.DarkGreen;
                            label_SEG_M1_C.BackColor = Color.Lime;
                            label_SEG_M1_D.BackColor = Color.Lime;
                            label_SEG_M1_E.BackColor = Color.Lime;
                            label_SEG_M1_F.BackColor = Color.Lime;
                            label_SEG_M1_G.BackColor = Color.Lime;
                            break;

                        case 7:
                            label_SEG_M1_A.BackColor = Color.Lime;
                            label_SEG_M1_B.BackColor = Color.Lime;
                            label_SEG_M1_C.BackColor = Color.Lime;
                            label_SEG_M1_D.BackColor = Color.DarkGreen;
                            label_SEG_M1_E.BackColor = Color.DarkGreen;
                            label_SEG_M1_F.BackColor = Color.DarkGreen;
                            label_SEG_M1_G.BackColor = Color.DarkGreen;
                            break;

                        case 8:
                            label_SEG_M1_A.BackColor = Color.Lime;
                            label_SEG_M1_B.BackColor = Color.Lime;
                            label_SEG_M1_C.BackColor = Color.Lime;
                            label_SEG_M1_D.BackColor = Color.Lime;
                            label_SEG_M1_E.BackColor = Color.Lime;
                            label_SEG_M1_F.BackColor = Color.Lime;
                            label_SEG_M1_G.BackColor = Color.Lime;
                            break;

                        case 9:
                            label_SEG_M1_A.BackColor = Color.Lime;
                            label_SEG_M1_B.BackColor = Color.Lime;
                            label_SEG_M1_C.BackColor = Color.Lime;
                            label_SEG_M1_D.BackColor = Color.Lime;
                            label_SEG_M1_E.BackColor = Color.DarkGreen;
                            label_SEG_M1_F.BackColor = Color.Lime;
                            label_SEG_M1_G.BackColor = Color.Lime;
                            break;
                    }

                    break;

                case SevenSeg_Types.Minute2:

                    switch (n)
                    {
                        case 0:
                            label_SEG_M2_A.BackColor = Color.Lime;
                            label_SEG_M2_B.BackColor = Color.Lime;
                            label_SEG_M2_C.BackColor = Color.Lime;
                            label_SEG_M2_D.BackColor = Color.Lime;
                            label_SEG_M2_E.BackColor = Color.Lime;
                            label_SEG_M2_F.BackColor = Color.Lime;
                            label_SEG_M2_G.BackColor = Color.DarkGreen;
                            break;

                        case 1:
                            label_SEG_M2_A.BackColor = Color.DarkGreen;
                            label_SEG_M2_B.BackColor = Color.Lime;
                            label_SEG_M2_C.BackColor = Color.Lime;
                            label_SEG_M2_D.BackColor = Color.DarkGreen;
                            label_SEG_M2_E.BackColor = Color.DarkGreen;
                            label_SEG_M2_F.BackColor = Color.DarkGreen;
                            label_SEG_M2_G.BackColor = Color.DarkGreen;
                            break;

                        case 2:
                            label_SEG_M2_A.BackColor = Color.Lime;
                            label_SEG_M2_B.BackColor = Color.Lime;
                            label_SEG_M2_C.BackColor = Color.DarkGreen;
                            label_SEG_M2_D.BackColor = Color.Lime;
                            label_SEG_M2_E.BackColor = Color.Lime;
                            label_SEG_M2_F.BackColor = Color.DarkGreen;
                            label_SEG_M2_G.BackColor = Color.Lime;
                            break;

                        case 3:
                            label_SEG_M2_A.BackColor = Color.Lime;
                            label_SEG_M2_B.BackColor = Color.Lime;
                            label_SEG_M2_C.BackColor = Color.Lime;
                            label_SEG_M2_D.BackColor = Color.Lime;
                            label_SEG_M2_E.BackColor = Color.DarkGreen;
                            label_SEG_M2_F.BackColor = Color.DarkGreen;
                            label_SEG_M2_G.BackColor = Color.Lime;
                            break;

                        case 4:
                            label_SEG_M2_A.BackColor = Color.DarkGreen;
                            label_SEG_M2_B.BackColor = Color.Lime;
                            label_SEG_M2_C.BackColor = Color.Lime;
                            label_SEG_M2_D.BackColor = Color.DarkGreen;
                            label_SEG_M2_E.BackColor = Color.DarkGreen;
                            label_SEG_M2_F.BackColor = Color.Lime;
                            label_SEG_M2_G.BackColor = Color.Lime;
                            break;

                        case 5:
                            label_SEG_M2_A.BackColor = Color.Lime;
                            label_SEG_M2_B.BackColor = Color.DarkGreen;
                            label_SEG_M2_C.BackColor = Color.Lime;
                            label_SEG_M2_D.BackColor = Color.Lime;
                            label_SEG_M2_E.BackColor = Color.DarkGreen;
                            label_SEG_M2_F.BackColor = Color.Lime;
                            label_SEG_M2_G.BackColor = Color.Lime;
                            break;

                        case 6:
                            label_SEG_M2_A.BackColor = Color.Lime;
                            label_SEG_M2_B.BackColor = Color.DarkGreen;
                            label_SEG_M2_C.BackColor = Color.Lime;
                            label_SEG_M2_D.BackColor = Color.Lime;
                            label_SEG_M2_E.BackColor = Color.Lime;
                            label_SEG_M2_F.BackColor = Color.Lime;
                            label_SEG_M2_G.BackColor = Color.Lime;
                            break;

                        case 7:
                            label_SEG_M2_A.BackColor = Color.Lime;
                            label_SEG_M2_B.BackColor = Color.Lime;
                            label_SEG_M2_C.BackColor = Color.Lime;
                            label_SEG_M2_D.BackColor = Color.DarkGreen;
                            label_SEG_M2_E.BackColor = Color.DarkGreen;
                            label_SEG_M2_F.BackColor = Color.DarkGreen;
                            label_SEG_M2_G.BackColor = Color.DarkGreen;
                            break;

                        case 8:
                            label_SEG_M2_A.BackColor = Color.Lime;
                            label_SEG_M2_B.BackColor = Color.Lime;
                            label_SEG_M2_C.BackColor = Color.Lime;
                            label_SEG_M2_D.BackColor = Color.Lime;
                            label_SEG_M2_E.BackColor = Color.Lime;
                            label_SEG_M2_F.BackColor = Color.Lime;
                            label_SEG_M2_G.BackColor = Color.Lime;
                            break;

                        case 9:
                            label_SEG_M2_A.BackColor = Color.Lime;
                            label_SEG_M2_B.BackColor = Color.Lime;
                            label_SEG_M2_C.BackColor = Color.Lime;
                            label_SEG_M2_D.BackColor = Color.Lime;
                            label_SEG_M2_E.BackColor = Color.DarkGreen;
                            label_SEG_M2_F.BackColor = Color.Lime;
                            label_SEG_M2_G.BackColor = Color.Lime;
                            break;
                    }

                    break;

                case SevenSeg_Types.Second1:

                    switch (n)
                    {
                        case 0:
                            label_SEG_S1_A.BackColor = Color.Lime;
                            label_SEG_S1_B.BackColor = Color.Lime;
                            label_SEG_S1_C.BackColor = Color.Lime;
                            label_SEG_S1_D.BackColor = Color.Lime;
                            label_SEG_S1_E.BackColor = Color.Lime;
                            label_SEG_S1_F.BackColor = Color.Lime;
                            label_SEG_S1_G.BackColor = Color.DarkGreen;
                            break;

                        case 1:
                            label_SEG_S1_A.BackColor = Color.DarkGreen;
                            label_SEG_S1_B.BackColor = Color.Lime;
                            label_SEG_S1_C.BackColor = Color.Lime;
                            label_SEG_S1_D.BackColor = Color.DarkGreen;
                            label_SEG_S1_E.BackColor = Color.DarkGreen;
                            label_SEG_S1_F.BackColor = Color.DarkGreen;
                            label_SEG_S1_G.BackColor = Color.DarkGreen;
                            break;

                        case 2:
                            label_SEG_S1_A.BackColor = Color.Lime;
                            label_SEG_S1_B.BackColor = Color.Lime;
                            label_SEG_S1_C.BackColor = Color.DarkGreen;
                            label_SEG_S1_D.BackColor = Color.Lime;
                            label_SEG_S1_E.BackColor = Color.Lime;
                            label_SEG_S1_F.BackColor = Color.DarkGreen;
                            label_SEG_S1_G.BackColor = Color.Lime;
                            break;

                        case 3:
                            label_SEG_S1_A.BackColor = Color.Lime;
                            label_SEG_S1_B.BackColor = Color.Lime;
                            label_SEG_S1_C.BackColor = Color.Lime;
                            label_SEG_S1_D.BackColor = Color.Lime;
                            label_SEG_S1_E.BackColor = Color.DarkGreen;
                            label_SEG_S1_F.BackColor = Color.DarkGreen;
                            label_SEG_S1_G.BackColor = Color.Lime;
                            break;

                        case 4:
                            label_SEG_S1_A.BackColor = Color.DarkGreen;
                            label_SEG_S1_B.BackColor = Color.Lime;
                            label_SEG_S1_C.BackColor = Color.Lime;
                            label_SEG_S1_D.BackColor = Color.DarkGreen;
                            label_SEG_S1_E.BackColor = Color.DarkGreen;
                            label_SEG_S1_F.BackColor = Color.Lime;
                            label_SEG_S1_G.BackColor = Color.Lime;
                            break;

                        case 5:
                            label_SEG_S1_A.BackColor = Color.Lime;
                            label_SEG_S1_B.BackColor = Color.DarkGreen;
                            label_SEG_S1_C.BackColor = Color.Lime;
                            label_SEG_S1_D.BackColor = Color.Lime;
                            label_SEG_S1_E.BackColor = Color.DarkGreen;
                            label_SEG_S1_F.BackColor = Color.Lime;
                            label_SEG_S1_G.BackColor = Color.Lime;
                            break;

                        case 6:
                            label_SEG_S1_A.BackColor = Color.Lime;
                            label_SEG_S1_B.BackColor = Color.DarkGreen;
                            label_SEG_S1_C.BackColor = Color.Lime;
                            label_SEG_S1_D.BackColor = Color.Lime;
                            label_SEG_S1_E.BackColor = Color.Lime;
                            label_SEG_S1_F.BackColor = Color.Lime;
                            label_SEG_S1_G.BackColor = Color.Lime;
                            break;

                        case 7:
                            label_SEG_S1_A.BackColor = Color.Lime;
                            label_SEG_S1_B.BackColor = Color.Lime;
                            label_SEG_S1_C.BackColor = Color.Lime;
                            label_SEG_S1_D.BackColor = Color.DarkGreen;
                            label_SEG_S1_E.BackColor = Color.DarkGreen;
                            label_SEG_S1_F.BackColor = Color.DarkGreen;
                            label_SEG_S1_G.BackColor = Color.DarkGreen;
                            break;

                        case 8:
                            label_SEG_S1_A.BackColor = Color.Lime;
                            label_SEG_S1_B.BackColor = Color.Lime;
                            label_SEG_S1_C.BackColor = Color.Lime;
                            label_SEG_S1_D.BackColor = Color.Lime;
                            label_SEG_S1_E.BackColor = Color.Lime;
                            label_SEG_S1_F.BackColor = Color.Lime;
                            label_SEG_S1_G.BackColor = Color.Lime;
                            break;

                        case 9:
                            label_SEG_S1_A.BackColor = Color.Lime;
                            label_SEG_S1_B.BackColor = Color.Lime;
                            label_SEG_S1_C.BackColor = Color.Lime;
                            label_SEG_S1_D.BackColor = Color.Lime;
                            label_SEG_S1_E.BackColor = Color.DarkGreen;
                            label_SEG_S1_F.BackColor = Color.Lime;
                            label_SEG_S1_G.BackColor = Color.Lime;
                            break;
                    }

                    break;

                case SevenSeg_Types.Second2:

                    switch (n)
                    {
                        case 0:
                            label_SEG_S2_A.BackColor = Color.Lime;
                            label_SEG_S2_B.BackColor = Color.Lime;
                            label_SEG_S2_C.BackColor = Color.Lime;
                            label_SEG_S2_D.BackColor = Color.Lime;
                            label_SEG_S2_E.BackColor = Color.Lime;
                            label_SEG_S2_F.BackColor = Color.Lime;
                            label_SEG_S2_G.BackColor = Color.DarkGreen;
                            break;

                        case 1:
                            label_SEG_S2_A.BackColor = Color.DarkGreen;
                            label_SEG_S2_B.BackColor = Color.Lime;
                            label_SEG_S2_C.BackColor = Color.Lime;
                            label_SEG_S2_D.BackColor = Color.DarkGreen;
                            label_SEG_S2_E.BackColor = Color.DarkGreen;
                            label_SEG_S2_F.BackColor = Color.DarkGreen;
                            label_SEG_S2_G.BackColor = Color.DarkGreen;
                            break;

                        case 2:
                            label_SEG_S2_A.BackColor = Color.Lime;
                            label_SEG_S2_B.BackColor = Color.Lime;
                            label_SEG_S2_C.BackColor = Color.DarkGreen;
                            label_SEG_S2_D.BackColor = Color.Lime;
                            label_SEG_S2_E.BackColor = Color.Lime;
                            label_SEG_S2_F.BackColor = Color.DarkGreen;
                            label_SEG_S2_G.BackColor = Color.Lime;
                            break;

                        case 3:
                            label_SEG_S2_A.BackColor = Color.Lime;
                            label_SEG_S2_B.BackColor = Color.Lime;
                            label_SEG_S2_C.BackColor = Color.Lime;
                            label_SEG_S2_D.BackColor = Color.Lime;
                            label_SEG_S2_E.BackColor = Color.DarkGreen;
                            label_SEG_S2_F.BackColor = Color.DarkGreen;
                            label_SEG_S2_G.BackColor = Color.Lime;
                            break;

                        case 4:
                            label_SEG_S2_A.BackColor = Color.DarkGreen;
                            label_SEG_S2_B.BackColor = Color.Lime;
                            label_SEG_S2_C.BackColor = Color.Lime;
                            label_SEG_S2_D.BackColor = Color.DarkGreen;
                            label_SEG_S2_E.BackColor = Color.DarkGreen;
                            label_SEG_S2_F.BackColor = Color.Lime;
                            label_SEG_S2_G.BackColor = Color.Lime;
                            break;

                        case 5:
                            label_SEG_S2_A.BackColor = Color.Lime;
                            label_SEG_S2_B.BackColor = Color.DarkGreen;
                            label_SEG_S2_C.BackColor = Color.Lime;
                            label_SEG_S2_D.BackColor = Color.Lime;
                            label_SEG_S2_E.BackColor = Color.DarkGreen;
                            label_SEG_S2_F.BackColor = Color.Lime;
                            label_SEG_S2_G.BackColor = Color.Lime;
                            break;

                        case 6:
                            label_SEG_S2_A.BackColor = Color.Lime;
                            label_SEG_S2_B.BackColor = Color.DarkGreen;
                            label_SEG_S2_C.BackColor = Color.Lime;
                            label_SEG_S2_D.BackColor = Color.Lime;
                            label_SEG_S2_E.BackColor = Color.Lime;
                            label_SEG_S2_F.BackColor = Color.Lime;
                            label_SEG_S2_G.BackColor = Color.Lime;
                            break;

                        case 7:
                            label_SEG_S2_A.BackColor = Color.Lime;
                            label_SEG_S2_B.BackColor = Color.Lime;
                            label_SEG_S2_C.BackColor = Color.Lime;
                            label_SEG_S2_D.BackColor = Color.DarkGreen;
                            label_SEG_S2_E.BackColor = Color.DarkGreen;
                            label_SEG_S2_F.BackColor = Color.DarkGreen;
                            label_SEG_S2_G.BackColor = Color.DarkGreen;
                            break;

                        case 8:
                            label_SEG_S2_A.BackColor = Color.Lime;
                            label_SEG_S2_B.BackColor = Color.Lime;
                            label_SEG_S2_C.BackColor = Color.Lime;
                            label_SEG_S2_D.BackColor = Color.Lime;
                            label_SEG_S2_E.BackColor = Color.Lime;
                            label_SEG_S2_F.BackColor = Color.Lime;
                            label_SEG_S2_G.BackColor = Color.Lime;
                            break;

                        case 9:
                            label_SEG_S2_A.BackColor = Color.Lime;
                            label_SEG_S2_B.BackColor = Color.Lime;
                            label_SEG_S2_C.BackColor = Color.Lime;
                            label_SEG_S2_D.BackColor = Color.Lime;
                            label_SEG_S2_E.BackColor = Color.DarkGreen;
                            label_SEG_S2_F.BackColor = Color.Lime;
                            label_SEG_S2_G.BackColor = Color.Lime;
                            break;
                    }

                    break;
            }
        }
    }
}
