using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Movements
{
    internal class Grid
    {
        Form form;
        int height, width;
        string path;
        string pic_path;

        List<List<Tiles>> tiles_List = new List<List<Tiles>>();
        List<List<string>> Listmap = new List<List<string>>();
        string map;
        void read()
        {

        }
        internal Grid(int width, int height, Form form, string path, string pic_path)
        {
            this.width = width;
            this.height = height;
            this.form = form;
            this.path = path;
            this.pic_path = pic_path;
            string file;
            try
            {
                file = File.ReadAllText(this.path);
                file = file.Replace(Environment.NewLine, ".");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(" Invalid Path ");
                file = "x,x,x,x.x,x,x";
            }
            string image = "";
            List<string> images = new List<string>();
            for (int idx = 0; idx < file.Length; idx++)
            {
                if (file[idx] != ',' && file[idx] != '.')
                {
                    image += file[idx];
                }
                if (file[idx] == ',')
                {
                    images.Add(image);
                    image = "";
                }
                else if (file[idx] == '.' || idx == file.Length - 1)
                {
                    images.Add(image);
                    this.Listmap.Add(images);
                    images = new List<string>();
                    image = "";
                }
            }
        }
        internal void addTilesToGrid()
        {
            int x = 0;
            int y = 0;
            foreach (List<string> imagesList in Listmap)
            {
                x = 0;
                List<Tiles> tiles = new List<Tiles>();
                foreach (string image in imagesList)
                {
                    if (image != "Empty")
                    {
                        string path = "";
                        if (File.Exists($"{this.pic_path}/{image}.png"))
                        {
                            path = $"{this.pic_path}/{image}.png";
                        }
                        else if (File.Exists($"{this.pic_path}/{image}.jpg"))
                        {
                            path = $"{this.pic_path}/{image}.jpg";
                        }
                        if (path != "")
                        {
                            Tiles tile = new Tiles(x * width, y * height, this.width, this.height, path, form);
                            tiles.Add(tile);
                        }
                    }
                    x++;
                }
                y++;
                tiles_List.Add(tiles);
                tiles = new List<Tiles>();
            }
        }

    }
}
internal class Tiles
{
    private static int counter = 0;
    private PictureBox picture;
    internal Tiles(int locationX, int locationY, int width, int height, string path, Form gameForm)
    {
        this.picture = new PictureBox();
        this.picture.Location = new System.Drawing.Point(locationX, locationY);
        this.picture.BackColor = System.Drawing.Color.Transparent;
        this.picture.Size = new System.Drawing.Size(width, height);
        this.picture.ImageLocation = path;
        this.picture.SizeMode = PictureBoxSizeMode.StretchImage;
        this.picture.Name = $"pictureBox{counter}";
        gameForm.Controls.Add(this.picture);
        counter++;
    }
    internal PictureBox getPicture()
    {
        return picture;
    }
}
