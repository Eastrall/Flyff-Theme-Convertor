using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*--------------------------------------------------------
 * Convertor.cs - file description
 * 
 * Version: 1.0
 * Author: Filipe
 * Created: 13/05/2014 21:15:58
 * 
 * Notes:
 * -------------------------------------------------------*/

namespace FlyffThemeConverter
{
    public class Convertor
    {
        /// <summary>
        /// Convert a .tga file to .png
        /// </summary>
        /// <param name="file">Input file</param>
        /// <param name="output">Output folder</param>
        public static void ConvertToPng(String file, String output)
        {
            try
            {
                String _file = Path.GetFileNameWithoutExtension(file);
                TargaImage _image = new TargaImage(file);
                _image.Image.Save(output + "\\" + _file + ".png", ImageFormat.Png);
                _image.Dispose();
            }
            catch (Exception) { }
        }
    }
}
