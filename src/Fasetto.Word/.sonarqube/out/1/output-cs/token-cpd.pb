�
jJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\Authentication\AuthorizeTokenAttribute.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Web 
. 
Server !
{		 
public 

class #
AuthorizeTokenAttribute (
:) *
AuthorizeAttribute+ =
{ 
public #
AuthorizeTokenAttribute &
(& '
)' (
{ 	!
AuthenticationSchemes !
=" #
JwtBearerDefaults$ 5
.5 6 
AuthenticationScheme6 J
;J K
} 	
} 
} �
eJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\Authentication\JwtTokenExtensions.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Web 
. 
Server !
{		 
public 

static 
class 
JwtTokenExtensions *
{ 
public 
static 
string 
GenerateJwtToken -
(- .
this. 2
ApplicationUser3 B
userC G
)G H
{ 	
var 
claims 
= 
new 
[ 
] 
{ 
new 
Claim 
( #
JwtRegisteredClaimNames 1
.1 2
Jti2 5
,5 6
Guid7 ;
.; <
NewGuid< C
(C D
)D E
.E F
ToStringF N
(N O
$strO R
)R S
)S T
,T U
new 
Claim 
( 
ClaimsIdentity (
.( ) 
DefaultNameClaimType) =
,= >
user? C
.C D
UserNameD L
)L M
,M N
new   
Claim   
(   

ClaimTypes   $
.  $ %
NameIdentifier  % 3
,  3 4
user  5 9
.  9 :
Id  : <
)  < =
,  = >
}!! 
;!! 
var$$ 
credentials$$ 
=$$ 
new$$ !
SigningCredentials$$" 4
($$4 5
new&&  
SymmetricSecurityKey&& (
(&&( )
Encoding&&) 1
.&&1 2
UTF8&&2 6
.&&6 7
GetBytes&&7 ?
(&&? @
	Framework&&@ I
.&&I J
Construction&&J V
.&&V W
Configuration&&W d
[&&d e
$str&&e t
]&&t u
)&&u v
)&&v w
,&&w x
SecurityAlgorithms(( "
.((" #

HmacSha256((# -
)((- .
;((. /
var++ 
token++ 
=++ 
new++ 
JwtSecurityToken++ ,
(++, -
issuer,, 
:,, 
	Framework,, !
.,,! "
Construction,," .
.,,. /
Configuration,,/ <
[,,< =
$str,,= I
],,I J
,,,J K
audience-- 
:-- 
	Framework-- #
.--# $
Construction--$ 0
.--0 1
Configuration--1 >
[--> ?
$str--? M
]--M N
,--N O
claims.. 
:.. 
claims.. 
,.. 
signingCredentials// "
://" #
credentials//$ /
,/// 0
expires11 
:11 
DateTime11 !
.11! "
Now11" %
.11% &
	AddMonths11& /
(11/ 0
$num110 1
)111 2
)22 
;22 
return55 
new55 #
JwtSecurityTokenHandler55 .
(55. /
)55/ 0
.550 1

WriteToken551 ;
(55; <
token55< A
)55A B
;55B C
}66 	
}77 
}88 ��
]J:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\Controllers\ApiController.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Web 
. 
Server !
{ 
[ 
AuthorizeToken 
] 
public 

class 
ApiController 
:  

Controller! +
{ 
	protected  
ApplicationDbContext &
mContext' /
;/ 0
	protected"" 
UserManager"" 
<"" 
ApplicationUser"" -
>""- .
mUserManager""/ ;
;""; <
	protected'' 
SignInManager'' 
<''  
ApplicationUser''  /
>''/ 0
mSignInManager''1 ?
;''? @
public33 
ApiController33 
(33  
ApplicationDbContext44  
context44! (
,44( )
UserManager55 
<55 
ApplicationUser55 '
>55' (
userManager55) 4
,554 5
SignInManager66 
<66 
ApplicationUser66 )
>66) *
signInManager66+ 8
)668 9
{77 	
mContext88 
=88 
context88 
;88 
mUserManager99 
=99 
userManager99 &
;99& '
mSignInManager:: 
=:: 
signInManager:: *
;::* +
};; 	
[DD 	
RouteDD	 
(DD 
	ApiRoutesDD 
.DD 
RegisterDD !
)DD! "
]DD" #
[EE 	
AllowAnonymousEE	 
]EE 
publicFF 
asyncFF 
TaskFF 
<FF 
ApiResponseFF %
<FF% &"
RegisterResultApiModelFF& <
>FF< =
>FF= >
RegisterAsyncFF? L
(FFL M
[FFM N
FromBodyFFN V
]FFV W'
RegisterCredentialsApiModelFFX s 
registerCredentials	FFt �
)
FF� �
{GG 	
varJJ 
invalidErrorMessageJJ #
=JJ$ %
$strJJ& f
;JJf g
varMM 
errorResponseMM 
=MM 
newMM  #
ApiResponseMM$ /
<MM/ 0"
RegisterResultApiModelMM0 F
>MMF G
{NN 
ErrorMessagePP 
=PP 
invalidErrorMessagePP 2
,PP2 3
}QQ 
;QQ 
ifTT 
(TT 
registerCredentialsTT #
==TT$ &
nullTT' +
)TT+ ,
returnVV 
errorResponseVV $
;VV$ %
ifYY 
(YY 
stringYY 
.YY 
IsNullOrWhiteSpaceYY )
(YY) *
registerCredentialsYY* =
.YY= >
UsernameYY> F
)YYF G
)YYG H
return[[ 
errorResponse[[ $
;[[$ %
var^^ 
user^^ 
=^^ 
new^^ 
ApplicationUser^^ *
{__ 
UserName`` 
=`` 
registerCredentials`` .
?``. /
.``/ 0
Username``0 8
,``8 9
	FirstNameaa 
=aa 
registerCredentialsaa /
?aa/ 0
.aa0 1
	FirstNameaa1 :
,aa: ;
LastNamebb 
=bb 
registerCredentialsbb .
?bb. /
.bb/ 0
LastNamebb0 8
,bb8 9
Emailcc 
=cc 
registerCredentialscc +
?cc+ ,
.cc, -
Emailcc- 2
,cc2 3
}dd 
;dd 
vargg 
resultgg 
=gg 
awaitgg 
mUserManagergg +
.gg+ ,
CreateAsyncgg, 7
(gg7 8
usergg8 <
,gg< =
registerCredentialsgg> Q
.ggQ R
PasswordggR Z
)ggZ [
;gg[ \
ifjj 
(jj 
resultjj 
.jj 
	Succeededjj  
)jj  !
{kk 
varmm 
userIdentitymm  
=mm! "
awaitmm# (
mUserManagermm) 5
.mm5 6
FindByNameAsyncmm6 E
(mmE F
registerCredentialsmmF Y
.mmY Z
UsernamemmZ b
)mmb c
;mmc d
varpp !
emailVerificationCodepp )
=pp* +
awaitpp, 1
mUserManagerpp2 >
.pp> ?/
#GenerateEmailConfirmationTokenAsyncpp? b
(ppb c
userppc g
)ppg h
;pph i
returnuu 
newuu 
ApiResponseuu &
<uu& '"
RegisterResultApiModeluu' =
>uu= >
{vv 
Responseww 
=ww 
newww ""
RegisterResultApiModelww# 9
{xx 
	FirstNameyy !
=yy" #
userIdentityyy$ 0
.yy0 1
	FirstNameyy1 :
,yy: ;
LastNamezz  
=zz! "
userIdentityzz# /
.zz/ 0
LastNamezz0 8
,zz8 9
Email{{ 
={{ 
userIdentity{{  ,
.{{, -
Email{{- 2
,{{2 3
Username||  
=||! "
userIdentity||# /
.||/ 0
UserName||0 8
,||8 9
Token}} 
=}} 
userIdentity}}  ,
.}}, -
GenerateJwtToken}}- =
(}}= >
)}}> ?
,}}? @
}~~ 
,~~ 
} 
; 
}
�� 
else
�� 
return
�� 
new
�� 
ApiResponse
�� &
<
��& '$
RegisterResultApiModel
��' =
>
��= >
{
�� 
ErrorMessage
��  
=
��! "
result
��# )
.
��) *
Errors
��* 0
.
��0 1
AggregateErrors
��1 @
(
��@ A
)
��A B
,
��B C
}
�� 
;
�� 
}
�� 	
[
�� 	
Route
��	 
(
�� 
	ApiRoutes
�� 
.
�� 
Login
�� 
)
�� 
]
��  
[
�� 	
AllowAnonymous
��	 
]
�� 
public
�� 
async
�� 
Task
�� 
<
�� 
ApiResponse
�� %
<
��% &(
UserProfileDetailsApiModel
��& @
>
��@ A
>
��A B

LogInAsync
��C M
(
��M N
[
��N O
FromBody
��O W
]
��W X&
LoginCredentialsApiModel
��Y q 
loginCreadentials��r �
)��� �
{
�� 	
var
�� !
invalidErrorMessage
�� #
=
��$ %
$str
��& D
;
��D E
var
�� 
errorResponse
�� 
=
�� 
new
��  #
ApiResponse
��$ /
<
��/ 0(
UserProfileDetailsApiModel
��0 J
>
��J K
{
�� 
ErrorMessage
�� 
=
�� !
invalidErrorMessage
�� 2
,
��2 3
}
�� 
;
�� 
if
�� 
(
�� 
loginCreadentials
�� !
?
��! "
.
��" #
UsernameOrEmail
��# 2
==
��3 5
null
��6 :
||
��; =
string
��> D
.
��D E 
IsNullOrWhiteSpace
��E W
(
��W X
loginCreadentials
��X i
.
��i j
UsernameOrEmail
��j y
)
��y z
)
��z {
return
�� 
errorResponse
�� $
;
��$ %
var
�� 
isEmail
�� 
=
�� 
loginCreadentials
�� +
.
��+ ,
UsernameOrEmail
��, ;
.
��; <
Contains
��< D
(
��D E
$str
��E H
)
��H I
;
��I J
var
�� 
user
�� 
=
�� 
isEmail
�� 
?
��  
await
�� 
mUserManager
�� "
.
��" #
FindByEmailAsync
��# 3
(
��3 4
loginCreadentials
��4 E
.
��E F
UsernameOrEmail
��F U
)
��U V
:
��W X
await
�� 
mUserManager
�� "
.
��" #
FindByNameAsync
��# 2
(
��2 3
loginCreadentials
��3 D
.
��D E
UsernameOrEmail
��E T
)
��T U
;
��U V
if
�� 
(
�� 
user
�� 
==
�� 
null
�� 
)
�� 
return
�� 
errorResponse
�� $
;
��$ %
var
�� 
isValidPassword
�� 
=
��  !
await
��" '
mUserManager
��( 4
.
��4 5 
CheckPasswordAsync
��5 G
(
��G H
user
��H L
,
��L M
loginCreadentials
��N _
.
��_ `
Password
��` h
)
��h i
;
��i j
if
�� 
(
�� 
!
�� 
isValidPassword
��  
)
��  !
return
�� 
errorResponse
�� $
;
��$ %
return
�� 
new
�� 
ApiResponse
�� "
<
��" #(
UserProfileDetailsApiModel
��# =
>
��= >
{
�� 
Response
�� 
=
�� 
new
�� (
UserProfileDetailsApiModel
�� 9
{
�� 
	FirstName
�� 
=
�� 
user
��  $
.
��$ %
	FirstName
��% .
,
��. /
LastName
�� 
=
�� 
user
�� #
.
��# $
LastName
��$ ,
,
��, -
Email
�� 
=
�� 
user
��  
.
��  !
Email
��! &
,
��& '
Username
�� 
=
�� 
user
�� #
.
��# $
UserName
��$ ,
,
��, -
Token
�� 
=
�� 
user
��  
.
��  !
GenerateJwtToken
��! 1
(
��1 2
)
��2 3
,
��3 4
}
�� 
}
�� 
;
�� 
}
�� 	
[
�� 	
Route
��	 
(
�� 
	ApiRoutes
�� 
.
�� 
GetUserProfile
�� '
)
��' (
]
��( )
public
�� 
async
�� 
Task
�� 
<
�� 
ApiResponse
�� %
<
��% &(
UserProfileDetailsApiModel
��& @
>
��@ A
>
��A B(
GetUserProfileDetailsAsync
��C ]
(
��] ^
)
��^ _
{
�� 	
var
�� 
user
�� 
=
�� 
await
�� 
mUserManager
�� )
.
��) *
GetUserAsync
��* 6
(
��6 7
HttpContext
��7 B
.
��B C
User
��C G
)
��G H
;
��H I
if
�� 
(
�� 
user
�� 
==
�� 
null
�� 
)
�� 
return
�� 
new
�� 
ApiResponse
�� &
<
��& '(
UserProfileDetailsApiModel
��' A
>
��A B
(
��B C
)
��C D
{
�� 
ErrorMessage
��  
=
��! "
$str
��# 3
}
�� 
;
�� 
return
�� 
new
�� 
ApiResponse
�� "
<
��" #(
UserProfileDetailsApiModel
��# =
>
��= >
{
�� 
Response
�� 
=
�� 
new
�� (
UserProfileDetailsApiModel
�� 9
{
�� 
	FirstName
�� 
=
�� 
user
��  $
.
��$ %
	FirstName
��% .
,
��. /
LastName
�� 
=
�� 
user
�� #
.
��# $
LastName
��$ ,
,
��, -
Email
�� 
=
�� 
user
��  
.
��  !
Email
��! &
,
��& '
Username
�� 
=
�� 
user
�� #
.
��# $
UserName
��$ ,
,
��, -
}
�� 
}
�� 
;
�� 
}
�� 	
[
�� 	
Route
��	 
(
�� 
	ApiRoutes
�� 
.
�� 
UpdateUserProfile
�� *
)
��* +
]
��+ ,
public
�� 
async
�� 
Task
�� 
<
�� 
ApiResponse
�� %
>
��% &$
UpdateUserProfileAsync
��' =
(
��= >
[
��> ?
FromBody
��? G
]
��G H'
UpdateUserProfileApiModel
��I b
model
��c h
)
��h i
{
�� 	
var
�� 
user
�� 
=
�� 
await
�� 
mUserManager
�� )
.
��) *
GetUserAsync
��* 6
(
��6 7
HttpContext
��7 B
.
��B C
User
��C G
)
��G H
;
��H I
if
�� 
(
�� 
user
�� 
==
�� 
null
�� 
)
�� 
return
�� 
new
�� 
ApiResponse
�� &
(
��& '
)
��' (
{
�� 
ErrorMessage
��  
=
��! "
$str
��# 3
}
�� 
;
�� 
if
�� 
(
�� 
model
�� 
.
�� 
	FirstName
�� 
!=
��  "
null
��# '
)
��' (
user
�� 
.
�� 
	FirstName
�� 
=
��  
model
��! &
.
��& '
	FirstName
��' 0
;
��0 1
if
�� 
(
�� 
model
�� 
.
�� 
LastName
�� 
!=
�� !
null
��" &
)
��& '
user
�� 
.
�� 
LastName
�� 
=
�� 
model
��  %
.
��% &
LastName
��& .
;
��. /
if
�� 
(
�� 
model
�� 
.
�� 
Username
�� 
!=
�� !
null
��" &
)
��& '
user
�� 
.
�� 
UserName
�� 
=
�� 
model
��  %
.
��% &
Username
��& .
;
��. /
var
�� 
result
�� 
=
�� 
await
�� 
mUserManager
�� +
.
��+ ,
UpdateAsync
��, 7
(
��7 8
user
��8 <
)
��< =
;
��= >
if
�� 
(
�� 
result
�� 
.
�� 
	Succeeded
��  
)
��  !
return
�� 
new
�� 
ApiResponse
�� &
(
��& '
)
��' (
;
��( )
else
�� 
return
�� 
new
�� 
ApiResponse
�� &
{
�� 
ErrorMessage
��  
=
��! "
result
��# )
.
��) *
Errors
��* 0
.
��0 1
AggregateErrors
��1 @
(
��@ A
)
��A B
,
��B C
}
�� 
;
�� 
}
�� 	
[
�� 	
Route
��	 
(
�� 
	ApiRoutes
�� 
.
��  
UpdateUserPassword
�� +
)
��+ ,
]
��, -
public
�� 
async
�� 
Task
�� 
<
�� 
ApiResponse
�� %
>
��% & 
UpdateUserPassword
��' 9
(
��9 :
[
��: ;
FromBody
��; C
]
��C D(
UpdateUserPasswordApiModel
��E _
model
��` e
)
��e f
{
�� 	
var
�� 
user
�� 
=
�� 
await
�� 
mUserManager
�� )
.
��) *
GetUserAsync
��* 6
(
��6 7
HttpContext
��7 B
.
��B C
User
��C G
)
��G H
;
��H I
if
�� 
(
�� 
user
�� 
==
�� 
null
�� 
)
�� 
return
�� 
new
�� 
ApiResponse
�� &
(
��& '
)
��' (
{
�� 
ErrorMessage
��  
=
��! "
$str
��# 3
}
�� 
;
�� 
var
�� 
result
�� 
=
�� 
await
�� 
mUserManager
�� +
.
��+ ,!
ChangePasswordAsync
��, ?
(
��? @
user
��@ D
,
��D E
model
��F K
.
��K L
CurrentPassword
��L [
,
��[ \
model
��] b
.
��b c
NewPassword
��c n
)
��n o
;
��o p
if
�� 
(
�� 
result
�� 
.
�� 
	Succeeded
��  
)
��  !
return
�� 
new
�� 
ApiResponse
�� &
(
��& '
)
��' (
;
��( )
else
�� 
return
�� 
new
�� 
ApiResponse
�� &
{
�� 
ErrorMessage
��  
=
��! "
result
��# )
.
��) *
Errors
��* 0
.
��0 1
AggregateErrors
��1 @
(
��@ A
)
��A B
,
��B C
}
�� 
;
�� 
}
�� 	
[
�� 	
Route
��	 
(
�� 
$str
�� 
)
�� 
]
�� 
[
�� 	
AllowAnonymous
��	 
]
�� 
public
�� 
async
�� 
Task
�� 
<
�� 
IActionResult
�� '
>
��' (
CreateUserAsync
��) 8
(
��8 9
)
��9 :
{
�� 	
var
�� 
result
�� 
=
�� 
await
�� 
mUserManager
�� +
.
��+ ,
CreateAsync
��, 7
(
��7 8
new
��8 ;
ApplicationUser
��< K
{
�� 
UserName
�� 
=
�� 
$str
�� %
,
��% &
Email
�� 
=
�� 
$str
�� .
,
��. /
	FirstName
�� 
=
�� 
$str
�� "
,
��" #
LastName
�� 
=
�� 
$str
�� $
,
��$ %
}
�� 
,
�� 
$str
�� 
)
�� 
;
�� 
if
�� 
(
�� 
result
�� 
.
�� 
	Succeeded
��  
)
��  !
return
�� 
Content
�� 
(
�� 
$str
�� 1
,
��1 2
$str
��3 >
)
��> ?
;
��? @
return
�� 
Content
�� 
(
�� 
$str
�� 1
,
��1 2
$str
��3 >
)
��> ?
;
��? @
}
�� 	
}
�� 
}�� �
iJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\Controllers\WeatherForecastController.cs
	namespace		 	
Fasetto		
 
.		 
Word		 
.		 
Web		 
.		 
Server		 !
.		! "
Controllers		" -
{

 
[ 
ApiController 
] 
[ 
Route 

(
 
$str 
) 
] 
public 

class %
WeatherForecastController *
:+ ,
ControllerBase- ;
{ 
private 
static 
readonly 
string  &
[& '
]' (
	Summaries) 2
=3 4
new5 8
[8 9
]9 :
{ 	
$str 
, 
$str !
,! "
$str# +
,+ ,
$str- 3
,3 4
$str5 ;
,; <
$str= C
,C D
$strE L
,L M
$strN S
,S T
$strU a
,a b
$strc n
} 	
;	 

private 
readonly 
ILogger  
<  !%
WeatherForecastController! :
>: ;
_logger< C
;C D
public %
WeatherForecastController (
(( )
ILogger) 0
<0 1%
WeatherForecastController1 J
>J K
loggerL R
)R S
{ 	
_logger 
= 
logger 
; 
} 	
[ 	
HttpGet	 
] 
public 
IEnumerable 
< 
WeatherForecast *
>* +
Get, /
(/ 0
)0 1
{ 	
var 
rng 
= 
new 
Random  
(  !
)! "
;" #
return 

Enumerable 
. 
Range #
(# $
$num$ %
,% &
$num' (
)( )
.) *
Select* 0
(0 1
index1 6
=>7 9
new: =
WeatherForecast> M
{   
Date!! 
=!! 
DateTime!! 
.!!  
Now!!  #
.!!# $
AddDays!!$ +
(!!+ ,
index!!, 1
)!!1 2
,!!2 3
TemperatureC"" 
="" 
rng"" "
.""" #
Next""# '
(""' (
-""( )
$num"") +
,""+ ,
$num""- /
)""/ 0
,""0 1
Summary## 
=## 
	Summaries## #
[### $
rng##$ '
.##' (
Next##( ,
(##, -
	Summaries##- 6
.##6 7
Length##7 =
)##= >
]##> ?
}$$ 
)$$ 
.%% 
ToArray%% 
(%% 
)%% 
;%% 
}&& 	
}'' 
}(( �
]J:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\Data\ApplicationDbContext.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Web 
. 
Server !
{ 
public

 

class

  
ApplicationDbContext

 %
:

& '
IdentityDbContext

( 9
<

9 :
ApplicationUser

: I
>

I J
{ 
public 
DbSet 
< 
SettingsDataModel &
>& '
Settings( 0
{1 2
get3 6
;6 7
set8 ;
;; <
}= >
public  
ApplicationDbContext #
(# $
DbContextOptions$ 4
<4 5 
ApplicationDbContext5 I
>I J
optionsK R
)R S
:T U
baseV Z
(Z [
options[ b
)b c
{ 	
} 	
	protected"" 
override"" 
void"" 
OnModelCreating""  /
(""/ 0
ModelBuilder""0 <
modelBuilder""= I
)""I J
{## 	
base$$ 
.$$ 
OnModelCreating$$  
($$  !
modelBuilder$$! -
)$$- .
;$$. /
modelBuilder(( 
.(( 
Entity(( 
<((  
SettingsDataModel((  1
>((1 2
(((2 3
)((3 4
.((4 5
HasIndex((5 =
(((= >
a((> ?
=>((@ B
a((C D
.((D E
Name((E I
)((I J
;((J K
})) 	
}** 
}++ �
XJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\Data\ApplicationUser.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Web 
. 
Server !
{ 
public 

class 
ApplicationUser  
:! "
IdentityUser# /
{ 
public 
string 
	FirstName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
LastName 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} �	
ZJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\Data\SettingsDataModel.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Web 
. 
Server !
{ 
public 

class 
SettingsDataModel "
{		 
[ 	
Key	 
] 
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
[ 	
Required	 
] 
[ 	
	MaxLength	 
( 
$num 
) 
] 
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
] 
[ 	
	MaxLength	 
( 
$num 
) 
] 
public 
string 
Value 
{ 
get !
;! "
set# &
;& '
}( )
} 
} �

dJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\Identity\IdentityErrorExtensions.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Web 
. 
Server !
{ 
public 

static 
class #
IdentityErrorExtensions /
{ 
public 
static 
string 
AggregateErrors ,
(, -
this- 1
IEnumerable2 =
<= >
IdentityError> K
>K L
errorsM S
)S T
{ 	
return 
errors 
? 
. 
ToList !
(! "
)" #
. 
Select 
(  
f  !
=>" $
f% &
.& '
Description' 2
)2 3
. 
	Aggregate "
(" #
(# $
a$ %
,% &
b' (
)( )
=>* ,
$"- /
{/ 0
a0 1
}1 2
{2 3
Environment3 >
.> ?
NewLine? F
}F G
{G H
bH I
}I J
"J K
)K L
;L M
} 	
} 
} �
KJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\Program.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Web 
. 
Server !
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
var 
host 
= 
CreateHostBuilder (
(( )
args) -
)- .
.. /
Build/ 4
(4 5
)5 6
;6 7
host 
. 
Run 
( 
) 
; 
} 	
public 
static 
IWebHostBuilder %
CreateHostBuilder& 7
(7 8
string8 >
[> ?
]? @
argsA E
)E F
=>G I
WebHost 
.  
CreateDefaultBuilder (
(( )
)) *
. 
UseDnaFramework  
(  !
	construct! *
=>+ -
{ 
	construct 
. 
AddFileLogger +
(+ ,
), -
;- .
}   
)   
.!! 

UseStartup!! 
<!! 
Startup!! #
>!!# $
(!!$ %
)!!% &
;!!& '
}"" 
}## �<
KJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\Startup.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Web 
. 
Server !
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services   
.   
	Configure   
<   
CookiePolicyOptions   2
>  2 3
(  3 4
options  4 ;
=>  < >
{!! 
options$$ 
.$$ 
CheckConsentNeeded$$ *
=$$+ ,
context$$- 4
=>$$5 7
true$$8 <
;$$< =
options%% 
.%% !
MinimumSameSitePolicy%% -
=%%. /
SameSiteMode%%0 <
.%%< =
None%%= A
;%%A B
}&& 
)&& 
;&& 
services)) 
.)) 
AddDbContext)) !
<))! " 
ApplicationDbContext))" 6
>))6 7
())7 8
options))8 ?
=>))@ B
options** 
.** 
UseSqlServer** $
(**$ %
	Framework**% .
.**. /
Construction**/ ;
.**; <
Configuration**< I
.**I J
GetConnectionString**J ]
(**] ^
$str**^ q
)**q r
)**r s
)**s t
;**t u
services00 
.00 
AddIdentity00  
<00  !
ApplicationUser00! 0
,000 1
IdentityRole002 >
>00> ?
(00? @
)00@ A
.66 $
AddEntityFrameworkStores66 )
<66) * 
ApplicationDbContext66* >
>66> ?
(66? @
)66@ A
.:: $
AddDefaultTokenProviders:: )
(::) *
)::* +
;::+ ,
services== 
.== 
AddAuthentication== &
(==& '
)==' (
.==( )
AddJwtBearer>> 
(>> 
options>> $
=>>>% '
{?? 
optionsAA 
.AA %
TokenValidationParametersAA 5
=AA6 7
newAA8 ;%
TokenValidationParametersAA< U
{BB 
ValidateIssuerDD &
=DD' (
trueDD) -
,DD- .
ValidateAudienceFF (
=FF) *
trueFF+ /
,FF/ 0
ValidateLifetimeHH (
=HH) *
trueHH+ /
,HH/ 0$
ValidateIssuerSigningKeyJJ 0
=JJ1 2
trueJJ3 7
,JJ7 8
ValidIssuerMM #
=MM$ %
	FrameworkMM& /
.MM/ 0
ConstructionMM0 <
.MM< =
ConfigurationMM= J
[MMJ K
$strMMK W
]MMW X
,MMX Y
ValidAudienceOO %
=OO& '
	FrameworkOO( 1
.OO1 2
ConstructionOO2 >
.OO> ?
ConfigurationOO? L
[OOL M
$strOOM [
]OO[ \
,OO\ ]
IssuerSigningKeyRR (
=RR) *
newRR+ . 
SymmetricSecurityKeyRR/ C
(RRC D
EncodingTT $
.TT$ %
UTF8TT% )
.TT) *
GetBytesTT* 2
(TT2 3
	FrameworkTT3 <
.TT< =
ConstructionTT= I
.TTI J
ConfigurationTTJ W
[TTW X
$strTTX g
]TTg h
)TTh i
)TTi j
,TTj k
}UU 
;UU 
}VV 
)VV 
;VV 
servicesYY 
.YY 
	ConfigureYY 
<YY 
IdentityOptionsYY .
>YY. /
(YY/ 0
optionsYY0 7
=>YY8 :
{ZZ 
options\\ 
.\\ 
Password\\  
.\\  !
RequireDigit\\! -
=\\. /
false\\0 5
;\\5 6
options]] 
.]] 
Password]]  
.]]  !
RequiredLength]]! /
=]]0 1
$num]]2 3
;]]3 4
options^^ 
.^^ 
Password^^  
.^^  !
RequireLowercase^^! 1
=^^2 3
true^^4 8
;^^8 9
options__ 
.__ 
Password__  
.__  !
RequireUppercase__! 1
=__2 3
false__4 9
;__9 :
options`` 
.`` 
Password``  
.``  !"
RequireNonAlphanumeric``! 7
=``8 9
false``: ?
;``? @
optionscc 
.cc 
Usercc 
.cc 
RequireUniqueEmailcc /
=cc0 1
truecc2 6
;cc6 7
}dd 
)dd 
;dd 
servicesgg 
.gg &
ConfigureApplicationCookiegg /
(gg/ 0
optionsgg0 7
=>gg8 :
{hh 
optionsjj 
.jj 
	LoginPathjj !
=jj" #
$strjj$ ,
;jj, -
optionsmm 
.mm 
ExpireTimeSpanmm &
=mm' (
TimeSpanmm) 1
.mm1 2
FromSecondsmm2 =
(mm= >
$nummm> B
)mmB C
;mmC D
}nn 
)nn 
;nn 
servicespp 
.pp 
AddControllerspp #
(pp# $
)pp$ %
;pp% &
}qq 	
publictt 
voidtt 
	Configurett 
(tt 
IApplicationBuildertt 1
apptt2 5
,tt5 6
IWebHostEnvironmenttt7 J
envttK N
,ttN O
IServiceProviderttP `
serviceProvidertta p
)ttp q
{uu 	
appww 
.ww 
UseDnaFrameworkww 
(ww  
)ww  !
;ww! "
appzz 
.zz 
UseAuthenticationzz !
(zz! "
)zz" #
;zz# $
if|| 
(|| 
env|| 
.|| 
IsDevelopment|| !
(||! "
)||" #
)||# $
{}} 
app~~ 
.~~ %
UseDeveloperExceptionPage~~ -
(~~- .
)~~. /
;~~/ 0
} 
app
�� 
.
�� !
UseHttpsRedirection
�� #
(
��# $
)
��$ %
;
��% &
app
�� 
.
�� 
UseStaticFiles
�� 
(
�� 
)
��  
;
��  !
app
�� 
.
�� 
UseCookiePolicy
�� 
(
��  
)
��  !
;
��! "
app
�� 
.
�� 

UseRouting
�� 
(
�� 
)
�� 
;
�� 
app
�� 
.
�� 
UseAuthorization
��  
(
��  !
)
��! "
;
��" #
app
�� 
.
�� 
UseEndpoints
�� 
(
�� 
	endpoints
�� &
=>
��' )
{
�� 
	endpoints
�� 
.
�� 
MapControllers
�� (
(
��( )
)
��) *
;
��* +
}
�� 
)
�� 
;
�� 
serviceProvider
�� 
.
�� 

GetService
�� &
<
��& '"
ApplicationDbContext
��' ;
>
��; <
(
��< =
)
��= >
.
��> ?
Database
��? G
.
��G H
EnsureCreated
��H U
(
��U V
)
��V W
;
��W X
}
�� 	
}
�� 
}�� �
SJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Web.Server\WeatherForecast.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Web 
. 
Server !
{ 
public 

class 
WeatherForecast  
{ 
public 
DateTime 
Date 
{ 
get "
;" #
set$ '
;' (
}) *
public		 
int		 
TemperatureC		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
public 
int 
TemperatureF 
=>  "
$num# %
+& '
(( )
int) ,
), -
(- .
TemperatureC. :
/; <
$num= C
)C D
;D E
public 
string 
Summary 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} 