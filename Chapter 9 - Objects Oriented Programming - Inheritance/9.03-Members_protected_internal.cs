// 9.03: Membros protected e internal.

// Protected: Nível intermediário de proteção entre public e o private.
// São acessados apenas nessa classe base ou em todas as classes derivadas dessa classe base.

// Internal: Nível intermediário de proteção.
// Os membros podem ser acessados apenas pelos objetos declarados no mesmo assembly.

using System;

public class ProtectedAndInternal
{
	protected int protect = 246;
	internal int intern = 680;
}