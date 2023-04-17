using Microsoft.Xna.Framework.Graphics;

namespace WPR.XnaCompability.Graphics
{
    public class GraphicsDevice2 : GraphicsDevice
    {
        public GraphicsDevice2(GraphicsAdapter adapter, 
            GraphicsProfile graphicsProfile, PresentationParameters presentationParameters) 
            : base(adapter, graphicsProfile, presentationParameters)
        {
        }

        public new DisplayMode DisplayMode
        {
            get
            {
                //return new DisplayMode(480, 800, base.DisplayMode.Format);
                return new DisplayMode(800, 600, base.DisplayMode.Format);
            }
        }
    }
}
