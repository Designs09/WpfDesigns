// Skipping function WriteAllTextToFileAsync(none, none, i1), it contains poisonous unsupported syntaxes

// Skipping function NormalizePath(none), it contains poisonous unsupported syntaxes

func @_Fasetto.Word.Core.FileManager.ResolvePath$string$(none) -> none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\File\\FileManager.cs" :61 :8) {
^entry (%_path : none):
%0 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\File\\FileManager.cs" :61 :34)
cbde.store %_path, %0 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\File\\FileManager.cs" :61 :34)
br ^0

^0: // JumpBlock
// Entity from another assembly: Path
%1 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\File\\FileManager.cs" :64 :36) // Not a variable of known type: path
%2 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\File\\FileManager.cs" :64 :19) // Path.GetFullPath(path) (InvocationExpression)
return %2 : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\File\\FileManager.cs" :64 :12)

^1: // ExitBlock
cbde.unreachable

}
