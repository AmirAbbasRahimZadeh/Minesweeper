using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;



namespace Minesweeper
{
    
    public static class global
    {
         public static bool islight = true; 
         public static bool issoundon = true;

         public static string endgame_text;

         public static bool stayopen; //if we want to keep game form open and just close the endgame form stayopen should be true

         public static Point gameform_loc;
         public static Point gametable_loc;
         public static Point gametable_size;

         public static string HistoryPath = Path.Combine(Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Minesweeper")).FullName, "History.txt");

         public class theme
         {
             public Color color1;
             public Color color2;
             public Color color3;
         }

         public static theme light = new theme
         {
             color1 = Color.FromArgb(255, 253, 208), 
             color2 = Color.FromArgb(0, 255, 127),
             color3 = Color.FromArgb(50, 205, 50),
         };
         public static theme dark = new theme
         {
             color1 = Color.FromArgb(0, 0, 0),
             color2 = Color.FromArgb(30, 60, 100),
             color3 = Color.FromArgb(20, 30, 60),
         };

         public static void changetheme(Control form, theme t)
         {
             form.BackColor = t.color1;
             foreach (Control c in form.Controls)
             {
                 TextBox tb = c as TextBox;
                 if (tb != null)
                 {
                     tb.ForeColor = t.color1;
                     tb.BackColor = t.color3;
                     tb.BorderStyle = BorderStyle.None;
                 }
                 Button btn = c as Button;
                 if (btn != null)
                 {
                     btn.ForeColor = t.color1;
                     btn.BackColor = t.color3;
                     btn.FlatStyle = FlatStyle.Flat;
                     btn.FlatAppearance.BorderColor = t.color2;
                 }    
             }
         }

         public static class Setting
         {
             public static int rows;
             public static int cols;
             public static int mins;
             public static string gamemode; // "Unlimited Hints" "Limited Hints" "Strict": without hints "Multiplayer"
         }

         public class btn_att
         {
             public char status; //f flaged, c closed, o opened
             public int row;
             public int col;
             public char back_status = '0'; // (0, 8) or m: min
             public bool not_bomb = false; //just used when bombs are too much
         }

         //create the table  
         public static Button[,] CreateTable(
         Panel container,
         int rows,
         int cols,
         int buttonSize,
         EventHandler onClick,
         MouseEventHandler rightClick)
        {
            container.Controls.Clear();
            Button[,] buttons = new Button[rows, cols]; //size of table
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Button btn = new Button //create buttons
                    {
                        Width = buttonSize,
                        Height = buttonSize,
                        Location = new Point(c * buttonSize, r * buttonSize),
                        Tag = new btn_att
                        {
                            row = r,
                            col = c,
                            status = 'c'
                        },
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", buttonSize * 0.35f)
                    };
                    if (islight == true)
                    {
                        btn.BackColor = light.color3;
                        btn.FlatAppearance.BorderColor = light.color2;
                    }
                    else
                    {
                        btn.BackColor = dark.color3;
                        btn.FlatAppearance.BorderColor = light.color2; //we use light2 for border in dark table
                    }
                    btn.Click += onClick; //when btn is clicked, onClick function will be run
                    btn.MouseDown += rightClick; //for right click
                    container.Controls.Add(btn);
                    buttons[r, c] = btn;
                }
            }
            return buttons;
        }
    }
}
