func @_Fasetto.Word.Core.RouteHelpers.GetAbsoluteRoute$string$(none) -> none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :24 :8) {
^entry (%_relativeUrl : none):
%0 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :24 :46)
cbde.store %_relativeUrl, %0 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :24 :46)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :27 :23) // Not a variable of known type: Host
%3 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :30 :16) // string (PredefinedType)
%4 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :30 :37) // Not a variable of known type: relativeUrl
%5 = cbde.unknown : i1 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :30 :16) // string.IsNullOrEmpty(relativeUrl) (InvocationExpression)
cond_br %5, ^1, ^2 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :30 :16)

^1: // JumpBlock
%6 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :31 :23) // Not a variable of known type: host
return %6 : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :31 :16)

^2: // BinaryBranchBlock
%7 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :34 :17) // Not a variable of known type: relativeUrl
%8 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :34 :40) // "/" (StringLiteralExpression)
%9 = cbde.unknown : i1 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :34 :17) // relativeUrl.StartsWith("/") (InvocationExpression)
%10 = cbde.unknown : i1 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :34 :16) // !relativeUrl.StartsWith("/") (LogicalNotExpression)
cond_br %10, ^3, ^4 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :34 :16)

^3: // SimpleBlock
%11 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :36 :34) // Not a variable of known type: relativeUrl
%12 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :36 :30) // $"/{relativeUrl}" (InterpolatedStringExpression)
br ^4

^4: // JumpBlock
%13 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :39 :19) // Not a variable of known type: host
%14 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :39 :26) // Not a variable of known type: relativeUrl
%15 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :39 :19) // Binary expression on unsupported types host + relativeUrl
return %15 : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Routes\\RouteHelpers.cs" :39 :12)

^5: // ExitBlock
cbde.unreachable

}
