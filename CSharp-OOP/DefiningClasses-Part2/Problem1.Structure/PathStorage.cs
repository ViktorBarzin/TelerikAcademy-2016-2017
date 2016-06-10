using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Problem1.Structure
{
    public static class PathStorage
    {
        // Save and read points in the format: {x},{y},{z}

        /// <summary>
        /// Load list of points from file.
        /// </summary>
        /// <param name="sourceFile">File to load path from.</param>
        /// <returns>The read path.</returns>
        public static List<Point3D> LoadPath(FileInfo sourceFile)
        {
            List<Point3D> path = new List<Point3D>();
            using(StringReader reader = new StringReader(sourceFile.FullName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    double[] splitedLine = line.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                    path.Add(new Point3D(splitedLine[0],splitedLine[1],splitedLine[2]));
                    line = reader.ReadLine();
                }
            }

            return path;
        }

        /// <summary>
        /// Save path to file.
        /// </summary>
        /// <param name="path">List of points to save.</param>
        /// <param name="filePath">Destination file path.</param>
        public static void SavePath(List<Point3D> path,string filePath)
        {
            using(StreamWriter wr = new StreamWriter(filePath))
            {
                foreach(var point in path)
                {
                    wr.WriteLine(point.ToString());
                }
            }
        }
    }
}
