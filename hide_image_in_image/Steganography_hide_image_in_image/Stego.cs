
using System.Drawing;
using System.Windows.Forms;

namespace hide_image_in_image
{
    class Stego
    {
        // Hide bm_hidden inside bm_visible and return the result.
        public static Bitmap HideImage(Bitmap bm_visible, Bitmap bm_hidden, int hidden_bits)
        {
            int r;
            int g;
            int b;
            Color clr_hidden;
            int shift = (8 - hidden_bits);
            int visible_mask = 0xFF << hidden_bits;
            int hidden_mask = 0xFF >> shift;
            Bitmap bm_combined = new Bitmap(bm_visible.Width, bm_visible.Height);
            clr_hidden = bm_hidden.GetPixel(0, 0);


            if ((bm_hidden.Width * bm_hidden.Height) <= (bm_visible.Width * bm_visible.Height)) //can only hide smaller inside bigger
            {

                for (int x = 0; x < bm_visible.Width; x++)
                {
                    for (int y = 0; y < bm_visible.Height; y++)
                    {
                        Color clr_visible = bm_visible.GetPixel(x, y);


                        if (bm_hidden.Width > x)
                        {
                            if (bm_hidden.Height > y)
                            {
                                clr_hidden = bm_hidden.GetPixel(x, y);
                                r = (clr_visible.R & visible_mask) + ((clr_hidden.R >> shift) & hidden_mask);
                                g = (clr_visible.G & visible_mask) + ((clr_hidden.G >> shift) & hidden_mask);
                                b = (clr_visible.B & visible_mask) + ((clr_hidden.B >> shift) & hidden_mask);
                            }
                            else
                            {
                                //Nothing to hide in this area so just rewrite original
                                r = clr_visible.R;
                                g = clr_visible.G;
                                b = clr_visible.B;
                            }
                        }
                        else //Nothing to hide in this area so just rewrite original
                        {
                            r = clr_visible.R;
                            g = clr_visible.G;
                            b = clr_visible.B;
                        }

                        bm_combined.SetPixel(x, y, Color.FromArgb(255, r, g, b));
                    }
                }

                return bm_combined;
            }
            else
            {
                MessageBox.Show("Image size to hide must be smaller or same as image you are hiding in.");
                return null;
            }
        }

        // Recover a hidden image.
        public static Bitmap RecoverImage(Bitmap bm_combined, Bitmap bm_hidden, Bitmap bm_visible, int hidden_bits)
        {

            if ((bm_hidden.Width* bm_hidden.Height) <= (bm_visible.Width * bm_visible.Height))
            {
                int shift = (8 - hidden_bits);
                int hidden_mask = 0xFF >> shift;
                Bitmap bm_recovered = new Bitmap(bm_hidden.Width, bm_hidden.Height);
                for (int x = 0; x < bm_hidden.Width; x++) //Only retrieve from area as big as the hidden one.
                {
                    for (int y = 0; y < bm_hidden.Height; y++)
                    {
                        Color clr_combined = bm_combined.GetPixel(x, y);
                        int r = (clr_combined.R & hidden_mask) << shift;
                        int g = (clr_combined.G & hidden_mask) << shift;
                        int b = (clr_combined.B & hidden_mask) << shift;

                        bm_recovered.SetPixel(x, y, Color.FromArgb(255, r, g, b));
                    }
                }

                return bm_recovered;
            }
            else
            {
                return null;
            }
        }
    }
}
