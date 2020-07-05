func @_Fasetto.Word.Core.UserProfileDetailsApiModel.ToLoginCredentialsDataModel$$() -> none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :45 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :47 :19) // new LoginCredentialsDataModel              {                  Id = Guid.NewGuid().ToString("N"),                  Email = Email,                  FirstName = FirstName,                  LastName = LastName,                  Username = Username,                  Token = Token,              } (ObjectCreationExpression)
// Entity from another assembly: Guid
%1 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :49 :21) // Guid.NewGuid() (InvocationExpression)
%2 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :49 :45) // "N" (StringLiteralExpression)
%3 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :49 :21) // Guid.NewGuid().ToString("N") (InvocationExpression)
%4 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :50 :24) // Not a variable of known type: Email
%5 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :51 :28) // Not a variable of known type: FirstName
%6 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :52 :27) // Not a variable of known type: LastName
%7 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :53 :27) // Not a variable of known type: Username
%8 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :54 :24) // Not a variable of known type: Token
return %0 : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Core\\ApiModels\\UserProfileDetailsApiModel.cs" :47 :12)

^1: // ExitBlock
cbde.unreachable

}
