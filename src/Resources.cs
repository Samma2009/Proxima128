/*
 *  This file is part of the Mirage Desktop Environment.
 *  github.com/mirage-desktop/Mirage
 */
#pragma warning disable CS8618
#pragma warning disable CS0649
#pragma warning disable CS8604

using Mirage.TextKit;
using IL2CPU.API.Attribs;
using Mirage.GraphicsKit;
using System.IO;

namespace Mirage
{
    public static class Resources
    {

        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Cantarell.acf")] private static readonly byte[] _cantarell; // GNOME 3.x/4x default font 
        public static readonly AcfFontFace Cantarell = new AcfFontFace(new MemoryStream(_cantarell));
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.CantarellBold.acf")] private static readonly byte[] _cantarellBold;
        public static readonly AcfFontFace CantarellBold = new AcfFontFace(new MemoryStream(_cantarellBold));
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.CantarellLarge.acf")] private static readonly byte[] _cantarellLarge;
        public static readonly AcfFontFace CantarellLarge = new AcfFontFace(new MemoryStream(_cantarellLarge));
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Serif.acf")] private static readonly byte[] _serif;
        public static readonly AcfFontFace Serif = new AcfFontFace(new MemoryStream(_serif));
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.LiberationSerif.acf")] private static readonly byte[] _liberationSerif;
        public static readonly AcfFontFace LiberationSerif = new AcfFontFace(new MemoryStream(_liberationSerif));
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Segment.acf")] private static readonly byte[] _segment;
        public static readonly AcfFontFace Segment = new AcfFontFace(new MemoryStream(_segment));
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Pointer.bmp")] private static readonly byte[] _pointer;
        public static readonly Canvas Pointer = Image.FromBitmap(_pointer);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Pointer_Resize.bmp")] private static readonly byte[] _pointerResize;
        public static readonly Canvas PointerResize = Image.FromBitmap(_pointerResize);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Pointer_Move.bmp")] private static readonly byte[] _pointerMove;
        public static readonly Canvas PointerMove = Image.FromBitmap(_pointerMove);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Pointer_IBeam.bmp")] private static readonly byte[] _pointerIBeam;
        public static readonly Canvas PointerIBeam = Image.FromBitmap(_pointerIBeam);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.TitleBar_Left.bmp")] private static readonly byte[] _titleBar_Left;
        public static readonly Canvas TitleBar_Left = Image.FromBitmap(_titleBar_Left);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.TitleBar_Middle.bmp")] private static readonly byte[] _titleBar_Middle;
        public static readonly Canvas TitleBar_Middle = Image.FromBitmap(_titleBar_Middle);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.TitleBar_Right.bmp")] private static readonly byte[] _titleBar_Right;
        public static readonly Canvas TitleBar_Right = Image.FromBitmap(_titleBar_Right);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Close.bmp")] private static readonly byte[] _close;
        public static readonly Canvas Close = Image.FromBitmap(_close);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Close_Hover.bmp")] private static readonly byte[] _close_Hover;
        public static readonly Canvas Close_Hover = Image.FromBitmap(_close_Hover);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Close_Press.bmp")] private static readonly byte[] _close_Press;
        public static readonly Canvas Close_Press = Image.FromBitmap(_close_Press);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Max.bmp")] private static readonly byte[] _max;
        public static readonly Canvas Max = Image.FromBitmap(_max);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Max_Hover.bmp")] private static readonly byte[] _max_Hover;
        public static readonly Canvas Max_Hover = Image.FromBitmap(_max_Hover);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Max_Press.bmp")] private static readonly byte[] _max_Press;
        public static readonly Canvas Max_Press = Image.FromBitmap(_max_Press);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Min.bmp")] private static readonly byte[] _min;
        public static readonly Canvas Min = Image.FromBitmap(_min);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Min_Hover.bmp")] private static readonly byte[] _min_Hover;
        public static readonly Canvas Min_Hover = Image.FromBitmap(_min_Hover);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Min_Press.bmp")] private static readonly byte[] _min_Press;
        public static readonly Canvas Min_Press = Image.FromBitmap(_min_Press);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Question.bmp")] private static readonly byte[] _question;
        public static readonly Canvas Question = Image.FromBitmap(_question);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Wallpaper.bmp")] private static readonly byte[] _wallpaper;
        public static readonly Canvas Wallpaper = Image.FromBitmap(_wallpaper);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Shadow_Corner_TopLeft.bmp")] private static readonly byte[] _shadowCornerTopLeft;
        public static readonly Canvas ShadowCornerTopLeft = Image.FromBitmap(_shadowCornerTopLeft);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Shadow_Corner_TopRight.bmp")] private static readonly byte[] _shadowCornerTopRight;
        public static readonly Canvas ShadowCornerTopRight = Image.FromBitmap(_shadowCornerTopRight);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Shadow_Corner_BottomLeft.bmp")] private static readonly byte[] _shadowCornerBottomLeft;
        public static readonly Canvas ShadowCornerBottomLeft = Image.FromBitmap(_shadowCornerBottomLeft);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Shadow_Corner_BottomRight.bmp")] private static readonly byte[] _shadowCornerBottomRight;
        public static readonly Canvas ShadowCornerBottomRight = Image.FromBitmap(_shadowCornerBottomRight);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Shadow_Edge_Left.bmp")] private static readonly byte[] _shadowEdgeLeft;
        public static readonly Canvas ShadowEdgeLeft = Image.FromBitmap(_shadowEdgeLeft);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Shadow_Edge_Right.bmp")] private static readonly byte[] _shadowEdgeRight;
        public static readonly Canvas ShadowEdgeRight = Image.FromBitmap(_shadowEdgeRight);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Shadow_Edge_Top.bmp")] private static readonly byte[] _shadowEdgeTop;
        public static readonly Canvas ShadowEdgeTop = Image.FromBitmap(_shadowEdgeTop);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Shadow_Edge_Bottom.bmp")] private static readonly byte[] _shadowEdgeBottom;
        public static readonly Canvas ShadowEdgeBottom = Image.FromBitmap(_shadowEdgeBottom);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.MenuSelectionGradient.bmp")] private static readonly byte[] _menuSelectionGradient;
        public static readonly Canvas MenuSelectionGradient = Image.FromBitmap(_menuSelectionGradient);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.ContextMenuSelectionGradient.bmp")] private static readonly byte[] _contextMenuSelectionGradient;
        public static readonly Canvas ContextMenuSelectionGradient = Image.FromBitmap(_contextMenuSelectionGradient);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Button.bmp")] private static readonly byte[] _button;
        public static readonly Canvas Button = Image.FromBitmap(_button);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Button_Press.bmp")] private static readonly byte[] _buttonPress;
        public static readonly Canvas ButtonPress = Image.FromBitmap(_buttonPress);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.DVD.bmp")] private static readonly byte[] _dvd;
        public static readonly Canvas DVD = Image.FromBitmap(_dvd);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Power.bmp")] private static readonly byte[] _power;
        public static readonly Canvas Power = Image.FromBitmap(_power);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Computer.bmp")] private static readonly byte[] _computer;
        public static readonly Canvas Computer = Image.FromBitmap(_computer);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.CheckBox.bmp")] private static readonly byte[] _checkBox;
        public static readonly Canvas CheckBox = Image.FromBitmap(_checkBox);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.CheckBox_Checked.bmp")] private static readonly byte[] _checkBoxChecked;
        public static readonly Canvas CheckBoxChecked = Image.FromBitmap(_checkBoxChecked);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.RadioButton.bmp")] private static readonly byte[] _radioButton;
        public static readonly Canvas RadioButton = Image.FromBitmap(_radioButton);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.RadioButton_Checked.bmp")] private static readonly byte[] _radioButtonChecked;
        public static readonly Canvas RadioButtonChecked = Image.FromBitmap(_radioButtonChecked);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Keyboard.bmp")] private static readonly byte[] _keyboard;
        public static readonly Canvas Keyboard = Image.FromBitmap(_keyboard);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Wallpaper1024.bmp")] private static readonly byte[] _wall1024;
        public static readonly Canvas Wallpaper1024 = Image.FromBitmap(_wall1024);
        [ManifestResourceStream(ResourceName = "Proxima128.Resources.Cantarell.ttf")]
        public static byte[] CantarellTTF;
    }
}

#pragma warning restore
