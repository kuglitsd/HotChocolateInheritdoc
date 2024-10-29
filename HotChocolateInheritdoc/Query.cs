namespace HotChocolateInheritdoc;

public class Query : IQuery
{
    /*
     *  Within same class
     */

    /// <summary>
    ///     TestMethodInQueryComment
    /// </summary>
    public void TestMethodInQuery()
    {
    }

    /// <inheritdoc cref="TestMethodInQuery" />
    public SomeObject TestMethodInQueryImpl() //-> Will NOT inherit
    {
        throw new NotImplementedException();
    }


    /*
     *  From Class
     */

    /// <inheritdoc cref="TestClass" />
    public SomeObject TestMethodInClass() //-> Will NOT inherit
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="TestClass.TestMethodInClass" />
    public SomeObject TestMethodInClassImpl() //-> Will NOT inherit
    {
        throw new NotImplementedException();
    }


    /*
     *  From Interface
     */

    /// <inheritdoc cref="ITestInterface" />
    public SomeObject TestMethodInterface() //-> Will NOT inherit
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="ITestInterface.TestMethodInterface" />
    public SomeObject TestMethodInterfaceImpl() //-> Will NOT inherit
    {
        throw new NotImplementedException();
    }

    /*
     * From implemented Interface
     */

    /// <inheritdoc cref="IQuery" />
    public SomeObject TestInterface() // -> Will Inherit
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc cref="IQuery.TestInterface" />
    public SomeObject TestInterfaceImpl() // -> Will NOT Inherit
    {
        throw new NotImplementedException();
    }
}