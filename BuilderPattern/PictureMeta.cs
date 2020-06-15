using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class PictureMeta
    {
        public string coordinate;
        public string author;
        public DateTime time;
        public int ISO;
        public float exposure;
        public DirectoryInfo path;

        public string WriteAllData()
        {
            var stringBuilder = new StringBuilder();

            if (coordinate != null)
            {
                stringBuilder.AppendFormat("Coordinate: {0}\n", coordinate);
            }
            if (author != null)
            {
                stringBuilder.AppendFormat("Author: {0}\n", author);
            }
            if (time != null)
            {
                stringBuilder.AppendFormat("Time: {0}\n", time.ToString());
            }
            if (ISO != null)
            {
                stringBuilder.AppendFormat("ISO: {0}\n", ISO);
            }
            if (exposure != null)
            {
                stringBuilder.AppendFormat("Exposure: {0}\n", exposure);
            }
            if (path != null)
            {
                stringBuilder.AppendFormat("Path: {0}\n", path.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
