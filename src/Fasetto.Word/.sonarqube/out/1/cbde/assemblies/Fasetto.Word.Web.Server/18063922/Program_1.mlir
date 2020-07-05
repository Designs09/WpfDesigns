func @_Fasetto.Word.Web.Server.Program.Main$string$$$(none) -> () loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Program.cs" :16 :8) {
^entry (%_args : none):
%0 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Program.cs" :16 :32)
cbde.store %_args, %0 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Program.cs" :16 :32)
br ^0

^0: // SimpleBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: CreateHostBuilder
%1 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Program.cs" :18 :41) // Not a variable of known type: args
%2 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Program.cs" :18 :23) // CreateHostBuilder(args) (InvocationExpression)
%3 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Program.cs" :18 :23) // CreateHostBuilder(args).Build() (InvocationExpression)
%5 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Program.cs" :19 :12) // Not a variable of known type: host
%6 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Program.cs" :19 :12) // host.Run() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
