using System;
using System.Drawing;
using System.IO;

namespace SkynetManager
{
    public class DeviceManager
    {
        public static Device GetDevice(DeviceBox deviceBox)
        {
            Device device = new Device();
            device.Name = deviceBox.BoxName;
            device.Ip = deviceBox.IpName;
            device.TCP = deviceBox.isWeb;

            if (int.TryParse(deviceBox.Port, out int Port))
                device.Port = Port;

            device.Interval = deviceBox.Interval;
            device.OpcionalLocation = deviceBox.OpcionalLocation;
            device.Orden = deviceBox.Orden;
            device.CircularAvatar = deviceBox.CircularAvatar;
            return device;
        }

        public static int GetDeviceCount()
        {
            int Count = 0;

            for (int i = 0; i < frmMain.frm.DeviceContainer.Controls.Count; i++)
            {
                if (frmMain.frm.DeviceContainer.Controls[i] is DeviceBox)
                {
                    Count++;
                }
            }
            return Count; 
        }

        public static string GetAvatarFromOrden(string name)
        {
            string path = "";

            if (!Directory.Exists(modCommon.CurrentDirectory + "/Data/Images/"))
            {
                Directory.CreateDirectory(modCommon.CurrentDirectory + "/Data/Images/");
                return "";
            }
            string[] files = Directory.GetFiles(modCommon.CurrentDirectory + "/Data/Images/");
            foreach (var picture in files)
            {
                if (picture.Contains(frmMain.CurrentSection + "_" + name + ".png"))
                {
                    path = picture;
                }
            }
            return path;
        }

        public static ImageType GetImageType(string imageFile)
        {
            string ext = Path.GetExtension(imageFile);

            if (ext.ToUpper() == ".JPG")
                return ImageType.JPG;
            else if (ext.ToUpper() == ".PNG")
                return ImageType.PNG;
            else if (ext.ToUpper() == ".ICO")
                return ImageType.ICO;
            else if (ext.ToUpper() == ".GIF")
                return ImageType.GIF;
            else
                return ImageType.PNG;
        }

        public static Image GetDeviceImage(DeviceBox device)
        {
            Image image = (Bitmap)default;
            string ImageFile = GetAvatarFromOrden(device.Name);

            if (File.Exists(ImageFile))
            {
                ImageType type = GetImageType(ImageFile);
                switch (type)
                {
                    case ImageType.JPG:
                        image = modCommon.ImageFromFile(ImageFile);
                        break;
                    case ImageType.PNG:
                        image = modCommon.ImageFromFile(ImageFile);
                        break;
                    case ImageType.ICO:
                        try
                        {
                            image = new Icon(ImageFile, 1000, 1000).ToBitmap();
                        }
                        catch (Exception)
                        {
                            image = Bitmap.FromHicon((new Icon(ImageFile).Handle));
                        }
                        break;
                    case ImageType.GIF:
                        image = modCommon.ImageFromFile(ImageFile);
                        break;
                    default:
                        image = modCommon.ImageFromFile(ImageFile);
                        break;
                }
            }
            return image;
        }
    }
}