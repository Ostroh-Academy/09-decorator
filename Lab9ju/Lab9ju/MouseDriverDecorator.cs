namespace Lab9ju;

public abstract class MouseDriverDecorator : IMouseDriver
{
    protected IMouseDriver wrappee;

    public MouseDriverDecorator(IMouseDriver source)
    {
        wrappee = source;
    }

    public virtual void Move(int x, int y)
    {
        wrappee.Move(x, y);
    }

    public virtual void Click()
    {
        wrappee.Click();
    }

    public virtual void RightClick()
    {
        wrappee.RightClick();
    }
}