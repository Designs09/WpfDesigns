func @_Fasetto.Word.Core.BaseLogFactory.AddLogger$Fasetto.Word.Core.ILogger$(none) -> () loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :77 :8) {
^entry (%_logger : none):
%0 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :77 :30)
cbde.store %_logger, %0 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :77 :30)
br ^0

^0: // LockBlock
%1 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :80 :18) // Not a variable of known type: mLoggersLock
br ^1

^1: // BinaryBranchBlock
%2 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :83 :21) // Not a variable of known type: mLoggers
%3 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :83 :39) // Not a variable of known type: logger
%4 = cbde.unknown : i1 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :83 :21) // mLoggers.Contains(logger) (InvocationExpression)
%5 = cbde.unknown : i1 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :83 :20) // !mLoggers.Contains(logger) (LogicalNotExpression)
cond_br %5, ^2, ^3 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :83 :20)

^2: // SimpleBlock
%6 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :85 :20) // Not a variable of known type: mLoggers
%7 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :85 :33) // Not a variable of known type: logger
%8 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :85 :20) // mLoggers.Add(logger) (InvocationExpression)
br ^3

^3: // ExitBlock
return

}
func @_Fasetto.Word.Core.BaseLogFactory.RemoveLogger$Fasetto.Word.Core.ILogger$(none) -> () loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :93 :8) {
^entry (%_logger : none):
%0 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :93 :33)
cbde.store %_logger, %0 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :93 :33)
br ^0

^0: // LockBlock
%1 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :96 :18) // Not a variable of known type: mLoggersLock
br ^1

^1: // BinaryBranchBlock
%2 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :99 :20) // Not a variable of known type: mLoggers
%3 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :99 :38) // Not a variable of known type: logger
%4 = cbde.unknown : i1 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :99 :20) // mLoggers.Contains(logger) (InvocationExpression)
cond_br %4, ^2, ^3 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :99 :20)

^2: // SimpleBlock
%5 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :101 :20) // Not a variable of known type: mLoggers
%6 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :101 :36) // Not a variable of known type: logger
%7 = cbde.unknown : i1 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\IoC\\Logging\\Implementation\\BaseLogFactory.cs" :101 :20) // mLoggers.Remove(logger) (InvocationExpression)
br ^3

^3: // ExitBlock
return

}
// Skipping function Log(none, none, none, none, i32), it contains poisonous unsupported syntaxes

