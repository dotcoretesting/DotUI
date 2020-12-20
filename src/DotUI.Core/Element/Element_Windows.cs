namespace DotUI.Core.Element
{
    public class Element_Windows : IElement
    {
        public IElement FindElement()
        {
            // throw new System.NotImplementedException();
            // return new Element_Windows();
            return new Element_Windows();
        }

        public IElement[] FindElements()
        {
            // throw new System.NotImplementedException();
            return new Element_Windows[] { new Element_Windows() };
        }
    }
}