using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RentACar
{
    class Pretvorba
    {
        public byte[] SlikaUBinarnu(Image slika)
        {
            if(slika != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    slika.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            return null;
        }

        public Image BinarnaUSliku(byte[] podaci)
        {
            using (MemoryStream ms = new MemoryStream(podaci))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
