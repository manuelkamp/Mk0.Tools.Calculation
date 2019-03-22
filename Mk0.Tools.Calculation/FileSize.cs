namespace Mk0.Tools.Calculation
{
    public class FileSize
    {
        /// <summary>
        /// Dateigröße in B,KB,MB,TB
        /// </summary>
        /// <param name="byteCount">Dateigröße in Bytes</param>
        /// <returns>Dateigröße in lesbarem Format mit Zusatz (KB, MB...)</returns>
        public static string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = string.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = string.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = string.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";

            return size;
        }
    }
}
