// -- FILE ------------------------------------------------------------------
// name       : RtfEmptyHtmlStyleConverter.cs
// project    : RTF Framelet
// created    : Jani Giannoudis - 2012.097.12
// language   : c#
// environment: .NET 2.0
// copyright  : (c) 2004-2012 by Itenso GmbH, Switzerland
// --------------------------------------------------------------------------

namespace Itenso.Rtf.Converter.Html
{

	// ------------------------------------------------------------------------
	public class RtfEmptyHtmlStyleConverter : IRtfHtmlStyleConverter
	{

		// ----------------------------------------------------------------------
		public virtual IRtfHtmlStyle TextToHtml( IRtfVisualText visualText )
		{
			return RtfHtmlStyle.Empty;
		} // TextToHtml

	} // class RtfEmptyHtmlStyleConverter

} // namespace Itenso.Rtf.Converter.Html
// -- EOF -------------------------------------------------------------------
