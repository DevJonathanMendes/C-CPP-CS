// Uma Classe define atributos e métodos que implementam a estrutura de dados e as suas operações.

class ClassBasicDeclaration
{
    int attribute;
    static int staticAttribute;

    const int constAttribute = 1;
    readonly int readonlyAttribute = 2;
    static readonly int staticReadonlyAttribute = 3;

    public int method()
    { return 0; }

    public ClassBasicDeclaration() // Construtor sem parâmetros é o padrão e pode ser omitido.
    { }

    static ClassBasicDeclaration() // Construtor static são chamados apenas uma única vez, etc.
    { }

    public ClassBasicDeclaration(int param) // Construtor customizado.
    { attribute = param; }

    // Destrutores
}

class ClassModifiesAccess
{
    public static int publicStaticAttribute;
    protected int protectedAttribute;
    internal int internalAttribute;
    protected internal int protectedInternalAttribute;
    private int privateAttribute; // Padrão.
}
