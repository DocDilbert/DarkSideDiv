using DarkSideDiv.Enums;

namespace DarkSideDiv.Common
{
  internal class AbsoluteLayout : IAbsoluteLayout
  {
    public AbsoluteLayout()
    {


    }

    public (float, float) GetOffset(Rect input_rect, Rect content_rect, DsAlignment alignment)
    {
      // the origin of a block is always the bottom left corner of it.
      // ^
      // |
      // |
      // |X <-- Origin
      // ------>
      var x = input_rect.Left;
      var y = input_rect.Bottom;


      switch (alignment)
      {

        case DsAlignment.Left:
          x = input_rect.Left;
          y = input_rect.Bottom + (input_rect.Top - input_rect.Bottom) * 0.5f + content_rect.Height * 0.5f;
          break;

        case DsAlignment.TopLeft:
          x = input_rect.Left;
          y = input_rect.Top + content_rect.Height;
          break;

        case DsAlignment.Right:
          x = input_rect.Right - content_rect.Width;
          y = input_rect.Bottom + (input_rect.Top - input_rect.Bottom) * 0.5f + content_rect.Height * 0.5f;
          break;

        case DsAlignment.TopRight:
          x = input_rect.Right - content_rect.Width;
          y = input_rect.Top + content_rect.Height;
          break;

        case DsAlignment.BottomRight:
          x = input_rect.Right - content_rect.Width;
          y = input_rect.Bottom;
          break;

        case DsAlignment.Bottom:
          x = input_rect.Left + (input_rect.Right - input_rect.Left) * 0.5f - content_rect.Width * 0.5f;
          y = input_rect.Bottom;
          break;

        case DsAlignment.Top:
          x = input_rect.Left + (input_rect.Right - input_rect.Left) * 0.5f - content_rect.Width * 0.5f;
          y = input_rect.Top + content_rect.Height;
          break;

        case DsAlignment.Center:

          // Left of center
          x = input_rect.Left + (input_rect.Right - input_rect.Left) * 0.5f - content_rect.Width * 0.5f;
          y = input_rect.Bottom + (input_rect.Top - input_rect.Bottom) * 0.5f + content_rect.Height * 0.5f;
          break;

        case DsAlignment.BottomLeft:
        default:
          // do nothing
          break;
      }

      return (x, y);
    }

  }
}

