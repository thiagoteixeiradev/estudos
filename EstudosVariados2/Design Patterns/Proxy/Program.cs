using Proxy;

ConfiguracaoProxy configuracaoProxy = new();

configuracaoProxy.Inicializar();
configuracaoProxy.SetConfig("key001", "Teste");
Console.WriteLine(configuracaoProxy.GetConfig("key001"));
