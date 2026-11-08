namespace CardCreator.Core.Rendering.Text;

/// <param name="Fits">False when text does not fit even at the minimum font size.</param>
public record TextFitResult(double FontSize, bool Fits);
