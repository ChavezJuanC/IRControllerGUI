using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace IRControllerGUI.WindowsInteractionsLib
{
    internal class WindowsInteractions
    {
        //Locking
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();

        //Media
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        //Media keys
        private const byte VK_MEDIA_PLAY_PAUSE = 0xB3;
        private const byte VK_MEDIA_PREV_TRACK = 0xB1;
        private const byte VK_MEDIA_NEXT_TRACK = 0xB0;
        private const byte VK_VOLUME_MUTE = 0xAD;
        private const byte VK_VOLUME_UP = 0xAF;
        private const byte VK_VOLUME_DOWN = 0xAE;

        //Other keys
        private const byte VK_SNAPSHOT = 0x2C;

        private const int KEYEVENTF_EXTENDEDKEY = 0x1;
        private const int KEYEVENTF_KEYUP = 0x2;

        #region Fixed Btn Functions

        public static void DesignateBtn(Button btn)
        {
            switch (btn.Name)
            {
                case "IRPowerButton":
                    btn.Click += (sender, e) => HandlePowerBtnDown();
                    break;

                case "IRPlayButton":
                    btn.Click += (sender, e) => HandleMediaEvent(VK_MEDIA_PLAY_PAUSE);
                    break;

                case "IRPrevButton":
                    btn.Click += (sender, e) => HandleMediaEvent(VK_MEDIA_PREV_TRACK);
                    break;

                case "IRNextButton":
                    btn.Click += (sender, e) => HandleMediaEvent(VK_MEDIA_NEXT_TRACK);
                    break;

                case "IRMuteButton":
                    btn.Click += (sender, e) => HandleMediaEvent(VK_VOLUME_MUTE);
                    break;

                case "IRVolDownButton":
                    btn.Click += (sender, e) => HandleMediaEvent(VK_VOLUME_DOWN);
                    break;

                case "IRVolUpButton":
                    btn.Click += (sender, e) => HandleMediaEvent(VK_VOLUME_UP);
                    break;

                case "IRCaptureButton":
                    btn.Click += (sender, e) => HandleMediaEvent(VK_SNAPSHOT);
                    break;

                case "IRUSBScanButton":
                    btn.Click += (sender, e) =>
                        OpenExecuteableInd(@"C:\WINDOWS\system32\cleanmgr.exe");
                    break;

                case "IREQButton":
                    btn.Click += (sender, e) =>
                        OpenExecuteableInd(@"C:\Program Files\FxSound LLC\FxSound\FxSound.exe");
                    break;

                case "IRGameButton":
                    btn.Click += (sender, e) => HandleGameBtnDown();
                    break;

                default:
                    MessageBox.Show("Error while mappping buttons");
                    break;
            }
        }

        //Execuateables/mapable buttons
        public static void OpenExecuteableInd(string file_path)
        {
            try
            {
                //Opens life as its own independent process...
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @file_path;
                Process.Start(startInfo);
                return;
            }
            catch
            {
                MessageBox.Show($"Error launching executeble. File: {file_path}");
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Power Button
        private static void HandlePowerBtnDown()
        {
            LockWorkStation();
        }

        // Media interactions
        public static void HandleMediaEvent(byte event_byte)
        {
            try
            {
                keybd_event(event_byte, 0, KEYEVENTF_EXTENDEDKEY, 0);
                keybd_event(event_byte, 0, KEYEVENTF_KEYUP, 0);
            }
            catch
            {
                MessageBox.Show("Media Error");
            }
        }

        //Random Game
        public static void HandleGameBtnDown()
        {
            //THIS DOESNT HAVE TO STAY A GAME BUTTON... THINK OF SOMETHING ELSE???
        }

        #endregion
    }
}
