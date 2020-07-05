func @_Fasetto.Word.Core.ExpressionHelpers.GetPropertyValue$T$$System.Linq.Expressions.Expression$System.Func$T$$$(none) -> none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :18 :8) {
^entry (%_lambda : none):
%0 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :18 :44)
cbde.store %_lambda, %0 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :18 :44)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :20 :19) // Not a variable of known type: lambda
%2 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :20 :19) // lambda.Compile() (InvocationExpression)
%3 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :20 :19) // lambda.Compile().Invoke() (InvocationExpression)
return %3 : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :20 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_Fasetto.Word.Core.ExpressionHelpers.GetPropertyValue$TInput.T$$System.Linq.Expressions.Expression$System.Func$TInput.T$$.TInput$(none, none) -> none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :30 :8) {
^entry (%_lambda : none, %_input : none):
%0 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :30 :52)
cbde.store %_lambda, %0 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :30 :52)
%1 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :30 :93)
cbde.store %_input, %1 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :30 :93)
br ^0

^0: // JumpBlock
%2 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :32 :19) // Not a variable of known type: lambda
%3 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :32 :19) // lambda.Compile() (InvocationExpression)
%4 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :32 :43) // Not a variable of known type: input
%5 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :32 :19) // lambda.Compile().Invoke(input) (InvocationExpression)
return %5 : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :32 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_Fasetto.Word.Core.ExpressionHelpers.SetPropertyValue$T$$System.Linq.Expressions.Expression$System.Func$T$$.T$(none, none) -> () loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :42 :8) {
^entry (%_lambda : none, %_value : none):
%0 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :42 :47)
cbde.store %_lambda, %0 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :42 :47)
%1 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :42 :80)
cbde.store %_value, %1 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :42 :80)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :45 :30) // Not a variable of known type: lambda
%3 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :45 :30) // lambda as LambdaExpression (AsExpression)
%4 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :45 :29) // (lambda as LambdaExpression).Body (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :45 :29) // (lambda as LambdaExpression).Body as MemberExpression (AsExpression)
%7 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :48 :45) // Not a variable of known type: expression
%8 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :48 :45) // expression.Member (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :48 :31) // (PropertyInfo)expression.Member (CastExpression)
// Entity from another assembly: Expression
%11 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :49 :43) // Not a variable of known type: expression
%12 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :49 :43) // expression.Expression (SimpleMemberAccessExpression)
%13 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :49 :25) // Expression.Lambda(expression.Expression) (InvocationExpression)
%14 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :49 :25) // Expression.Lambda(expression.Expression).Compile() (InvocationExpression)
%15 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :49 :25) // Expression.Lambda(expression.Expression).Compile().DynamicInvoke() (InvocationExpression)
%17 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :52 :12) // Not a variable of known type: propertyInfo
%18 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :52 :34) // Not a variable of known type: target
%19 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :52 :42) // Not a variable of known type: value
%20 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :52 :12) // propertyInfo.SetValue(target, value) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_Fasetto.Word.Core.ExpressionHelpers.SetPropertyValue$TInput.T$$System.Linq.Expressions.Expression$System.Func$TInput.T$$.TInput.T$(none, none, none) -> () loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :63 :8) {
^entry (%_lambda : none, %_input : none, %_value : none):
%0 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :63 :55)
cbde.store %_lambda, %0 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :63 :55)
%1 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :63 :96)
cbde.store %_input, %1 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :63 :96)
%2 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :63 :110)
cbde.store %_value, %2 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :63 :110)
br ^0

^0: // SimpleBlock
%3 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :66 :30) // Not a variable of known type: lambda
%4 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :66 :30) // lambda as LambdaExpression (AsExpression)
%5 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :66 :29) // (lambda as LambdaExpression).Body (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :66 :29) // (lambda as LambdaExpression).Body as MemberExpression (AsExpression)
%8 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :69 :45) // Not a variable of known type: expression
%9 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :69 :45) // expression.Member (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :69 :31) // (PropertyInfo)expression.Member (CastExpression)
%12 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :72 :12) // Not a variable of known type: propertyInfo
%13 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :72 :34) // Not a variable of known type: input
%14 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :72 :41) // Not a variable of known type: value
%15 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\Expressions\\ExpressionHelpers.cs" :72 :12) // propertyInfo.SetValue(input, value) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
