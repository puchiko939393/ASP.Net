using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Window
    {
        protected int top;
        protected int left;
        public Window(int top, int left)
        {
            Console.WriteLine("Window is created.");
            this.top = top;
            this.left = left;
        }
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}", top, left);
        }
    }
    public class Listbox : Window
    {
        private string listBoxContents;
        public Listbox(int top, int left, string contents)
        : base(top, left)
        {
            Console.WriteLine("Window Type: ListBox");
            this.listBoxContents = contents;
        }
        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Write string to the listbox: {0}", listBoxContents);
        }
    }
    public class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        {
            Console.WriteLine("Windows Type: Button");
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at{0}, {1}\n", top, left);

        }
    }

    public class Tester
    {
        static void Main()
        {
            Window win = new Window(1, 2);
            Listbox lb = new Listbox(3, 4, "Stand alone list box");
            Button b = new Button(5, 6);
            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();

            Window[] winArray = new Window[3];
            winArray[0] = new Window(1, 2);
            winArray[1] = new Listbox(3, 4, "List box in array");

            winArray[2] = new Button(5, 6);
            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }
            Console.ReadLine();

        }
    }
}
