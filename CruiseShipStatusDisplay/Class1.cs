using CoreAudioManager;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace subR
{



    class Monitor
    {
        const int SC_MONITORPOWER = 0xf170;
        const int WM_SYSCOMMAND = 0x112;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(int hWnd, uint Msg, int wParam, int lParam);
        public static void PowerOff()
        {
            //モニター停止
            SendMessage(-1, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }
    }
    class Volume
    {
        public static void SetMasterVolume(float newLevel)
        {
            //
            // https://shikaku-sh.hatenablog.com/ こちらのBlogのソースコードそのまんま使っています
            // https://shikaku-sh.hatenablog.com/entry/c-charp-how-to-use-core-audio-api
            // 
            IAudioEndpointVolume? masterVol = null;
            try
            {
                masterVol = GetMasterVolumeObject();
                if (masterVol == null) { return; }
                masterVol.SetMasterVolumeLevelScalar(newLevel / 100, Guid.Empty);
            }
            finally
            {
                if (masterVol != null) { Marshal.ReleaseComObject(masterVol); }
            }
        }
        public static IAudioEndpointVolume GetMasterVolumeObject()
        {
            //
            // https://shikaku-sh.hatenablog.com/ こちらのBlogのソースコード丸ごと使っています
            // https://shikaku-sh.hatenablog.com/entry/c-charp-how-to-use-core-audio-api
            // 
            IMMDeviceEnumerator? deviceEnumerator = null;
            IMMDevice? speakers = null;
            try
            {
                deviceEnumerator = (IMMDeviceEnumerator)(new MMDeviceEnumerator());
                deviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out speakers);
                Guid IID_IAudioEndpointVolume = typeof(IAudioEndpointVolume).GUID;
                speakers.Activate(ref IID_IAudioEndpointVolume, 0, IntPtr.Zero, out object endpointVolume);
                IAudioEndpointVolume masterVol = (IAudioEndpointVolume)endpointVolume;
                return masterVol;
            }
            finally
            {
                if (speakers != null) Marshal.ReleaseComObject(speakers);
                if (deviceEnumerator != null) Marshal.ReleaseComObject(deviceEnumerator);
            }
        }
        public static float GetMasterVolume()
        {
            //
            //https://gist.github.com/sverrirs/d099b34b7f72bb4fb386 こちらのソースコードの一部を使っています
            //
            IAudioEndpointVolume? masterVol = null;
            try
            {
                masterVol = GetMasterVolumeObject();
                if (masterVol == null)
                    return -1;

                float volumeLevel;
                masterVol.GetMasterVolumeLevelScalar(out volumeLevel);
                return volumeLevel * 100;
            }
            finally
            {
                if (masterVol != null)
                    Marshal.ReleaseComObject(masterVol);
            }
        }
    }

}
