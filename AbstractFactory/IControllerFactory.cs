namespace AbstractFactory
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public interface IControllerFactory
    {
        IOperation CreateOperation();
        IInterface CreateInterface();
    }
}
