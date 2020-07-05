º
SJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\ApiModels\ApiResponse.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

class 
ApiResponse 
{ 
public 
bool 

Successful 
=> !
ErrorMessage" .
==/ 1
null2 6
;6 7
public 
string 
ErrorMessage "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
public 

class 
ApiResponse 
< 
T 
> 
:  !
ApiResponse" -
{ 
public## 
T## 
Response## 
{## 
get## 
;##  
set##! $
;##$ %
}##& '
}&& 
}'' í
`J:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\ApiModels\LoginCredentialsApiModel.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

class $
LoginCredentialsApiModel )
{ 
public 
string 
UsernameOrEmail %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} „
cJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\ApiModels\RegisterCredentialsApiModel.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

class '
RegisterCredentialsApiModel ,
{ 
public 
string 
Username 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
	FirstName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
LastName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
}   
}!! Ü
^J:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\ApiModels\RegisterResultApiModel.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

class "
RegisterResultApiModel '
:( )&
UserProfileDetailsApiModel* D
{E F
}G H
} ô
bJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\ApiModels\UpdateUserPasswordApiModel.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

class &
UpdateUserPasswordApiModel +
{ 
public 
string 
CurrentPassword %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
NewPassword !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
} √
aJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\ApiModels\UpdateUserProfileApiModel.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public

 

class

 %
UpdateUserProfileApiModel

 *
{ 
public 
string 
	FirstName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
LastName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Username 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
}   
}!! ∂
bJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\ApiModels\UserProfileDetailsApiModel.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

class &
UserProfileDetailsApiModel +
{		 
public 
string 
Token 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
	FirstName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
LastName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Username 
{  
get! $
;$ %
set& )
;) *
}+ ,
public## 
string## 
Email## 
{## 
get## !
;##! "
set### &
;##& '
}##( )
public.. %
LoginCredentialsDataModel.. ('
ToLoginCredentialsDataModel..) D
(..D E
)..E F
{// 	
return00 
new00 %
LoginCredentialsDataModel00 0
{11 
Id22 
=22 
Guid22 
.22 
NewGuid22 !
(22! "
)22" #
.22# $
ToString22$ ,
(22, -
$str22- 0
)220 1
,221 2
Email33 
=33 
Email33 
,33 
	FirstName44 
=44 
	FirstName44 %
,44% &
LastName55 
=55 
LastName55 #
,55# $
Username66 
=66 
Username66 #
,66# $
Token77 
=77 
Token77 
,77 
}88 
;88 
}99 	
}<< 
}== Ú*
PJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\Async\AsyncAwaiter.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{		 
public 

static 
class 
AsyncAwaiter $
{ 
private 
static 
SemaphoreSlim $
SelfLock% -
=. /
new0 3
SemaphoreSlim4 A
(A B
$numB C
,C D
$numE F
)F G
;G H
private 
static 

Dictionary !
<! "
string" (
,( )
SemaphoreSlim* 7
>7 8

Semaphores9 C
=D E
newF I

DictionaryJ T
<T U
stringU [
,[ \
SemaphoreSlim] j
>j k
(k l
)l m
;m n
public(( 
static(( 
async(( 
Task((  
<((  !
T((! "
>((" #
AwaitResultAsync(($ 4
<((4 5
T((5 6
>((6 7
(((7 8
string((8 >
key((? B
,((B C
Func((D H
<((H I
Task((I M
<((M N
T((N O
>((O P
>((P Q
task((R V
,((V W
int((X [
maxAccessCount((\ j
=((k l
$num((m n
)((n o
{)) 	
await33 
SelfLock33 
.33 
	WaitAsync33 $
(33$ %
)33% &
;33& '
try55 
{66 
if88 
(88 
!88 

Semaphores88 
.88  
ContainsKey88  +
(88+ ,
key88, /
)88/ 0
)880 1

Semaphores99 
.99 
Add99 "
(99" #
key99# &
,99& '
new99( +
SemaphoreSlim99, 9
(999 :
maxAccessCount99: H
,99H I
maxAccessCount99J X
)99X Y
)99Y Z
;99Z [
}:: 
finally;; 
{<< 
SelfLockEE 
.EE 
ReleaseEE  
(EE  !
)EE! "
;EE" #
}FF 
varLL 
	semaphoreLL 
=LL 

SemaphoresLL &
[LL& '
keyLL' *
]LL* +
;LL+ ,
awaitOO 
	semaphoreOO 
.OO 
	WaitAsyncOO %
(OO% &
)OO& '
;OO' (
tryQQ 
{RR 
returnTT 
awaitTT 
taskTT !
(TT! "
)TT" #
;TT# $
}UU 
finallyVV 
{WW 
	semaphoreYY 
.YY 
ReleaseYY !
(YY! "
)YY" #
;YY# $
}ZZ 
}[[ 	
publicdd 
staticdd 
asyncdd 
Taskdd  

AwaitAsyncdd! +
(dd+ ,
stringdd, 2
keydd3 6
,dd6 7
Funcdd8 <
<dd< =
Taskdd= A
>ddA B
taskddC G
,ddG H
intddI L
maxAccessCountddM [
=dd\ ]
$numdd^ _
)dd_ `
{ee 	
awaitoo 
SelfLockoo 
.oo 
	WaitAsyncoo $
(oo$ %
)oo% &
;oo& '
tryqq 
{rr 
iftt 
(tt 
!tt 

Semaphorestt 
.tt  
ContainsKeytt  +
(tt+ ,
keytt, /
)tt/ 0
)tt0 1

Semaphoresuu 
.uu 
Adduu "
(uu" #
keyuu# &
,uu& '
newuu( +
SemaphoreSlimuu, 9
(uu9 :
maxAccessCountuu: H
,uuH I
maxAccessCountuuJ X
)uuX Y
)uuY Z
;uuZ [
}vv 
finallyww 
{xx 
SelfLock
ÅÅ 
.
ÅÅ 
Release
ÅÅ  
(
ÅÅ  !
)
ÅÅ! "
;
ÅÅ" #
}
ÇÇ 
var
àà 
	semaphore
àà 
=
àà 

Semaphores
àà &
[
àà& '
key
àà' *
]
àà* +
;
àà+ ,
await
ãã 
	semaphore
ãã 
.
ãã 
	WaitAsync
ãã %
(
ãã% &
)
ãã& '
;
ãã' (
try
çç 
{
éé 
await
êê 
task
êê 
(
êê 
)
êê 
;
êê 
}
ëë 
catch
íí 
(
íí 
	Exception
íí 
ex
íí 
)
íí  
{
ìì 
var
ïï 
error
ïï 
=
ïï 
ex
ïï 
.
ïï 
Message
ïï &
;
ïï& '
FrameworkDI
ôô 
.
ôô 
Logger
ôô "
.
ôô" #
LogDebugSource
ôô# 1
(
ôô1 2
$"
ôô2 4
	Crash in 
ôô4 =
{
ôô= >
nameof
ôô> D
(
ôôD E

AwaitAsync
ôôE O
)
ôôO P
}
ôôP Q
. 
ôôQ S
{
ôôS T
ex
ôôT V
.
ôôV W
Message
ôôW ^
}
ôô^ _
"
ôô_ `
)
ôô` a
;
ôôa b
Debugger
úú 
.
úú 
Break
úú 
(
úú 
)
úú  
;
úú  !
throw
üü 
;
üü 
}
†† 
finally
°° 
{
¢¢ 
	semaphore
§§ 
.
§§ 
Release
§§ !
(
§§! "
)
§§" #
;
§§# $
}
•• 
}
¶¶ 	
}
ßß 
}®® å
XJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\DataModels\ApplicationPage.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

enum 
ApplicationPage 
{ 
Login 
= 
$num 
, 
Chat 
= 
$num 
, 
Register 
= 
$num 
, 
} 
} ÷
cJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\DataModels\ElementHorizontalAlignment.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

enum &
ElementHorizontalAlignment *
{ 
Left 
= 
$num 
, 
Center 
= 
$num 
, 
Right 
= 
$num 
, 
Stretch 
= 
$num 
} 
} ¸
QJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\DataModels\IconType.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

enum 
IconType 
{ 
None 
= 
$num 
, 
Picrure 
= 
$num 
, 
File 
= 
$num 
, 
} 
} Û	
bJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\DataModels\LoginCredentialsDataModel.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public

 

class

 %
LoginCredentialsDataModel

 *
{ 
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
public 
string 
Username 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
	FirstName 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
LastName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public## 
string## 
Email## 
{## 
get## !
;##! "
set### &
;##& '
}##( )
public(( 
string(( 
Token(( 
{(( 
get(( !
;((! "
set((# &
;((& '
}((( )
})) 
}** ç
UJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\DataModels\MenuItemType.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

enum 
MenuItemType 
{ 
TextAndIcon 
= 
$num 
, 
Divider 
= 
$num 
, 
Header 
= 
$num 
, 
} 
} å
XJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\DataModels\SideMenuContent.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

enum 
SideMenuContent 
{ 
Chat 
= 
$num 
, 
Contacts 
= 
$num 
, 
Media 
= 
$num 
, 
} 
} ≤
[J:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\Expressions\ExpressionHelpers.cs
	namespace		 	
Fasetto		
 
.		 
Word		 
.		 
Core		 
{

 
public 

static 
class 
ExpressionHelpers )
{ 
public 
static 
T 
GetPropertyValue (
<( )
T) *
>* +
(+ ,
this, 0

Expression1 ;
<; <
Func< @
<@ A
TA B
>B C
>C D
lambdaE K
)K L
{ 	
return 
lambda 
. 
Compile !
(! "
)" #
.# $
Invoke$ *
(* +
)+ ,
;, -
} 	
public 
static 
T 
GetPropertyValue (
<( )
TInput) /
,/ 0
T1 2
>2 3
(3 4
this4 8

Expression9 C
<C D
FuncD H
<H I
TInputI O
,O P
TQ R
>R S
>S T
lambdaU [
,[ \
TInput] c
inputd i
)i j
{   	
return!! 
lambda!! 
.!! 
Compile!! !
(!!! "
)!!" #
.!!# $
Invoke!!$ *
(!!* +
input!!+ 0
)!!0 1
;!!1 2
}"" 	
public++ 
static++ 
void++ 
SetPropertyValue++ +
<+++ ,
T++, -
>++- .
(++. /
this++/ 3

Expression++4 >
<++> ?
Func++? C
<++C D
T++D E
>++E F
>++F G
lambda++H N
,++N O
T++P Q
value++R W
)++W X
{,, 	
var.. 

expression.. 
=.. 
(.. 
lambda.. $
as..% '
LambdaExpression..( 8
)..8 9
...9 :
Body..: >
as..? A
MemberExpression..B R
;..R S
var11 
propertyInfo11 
=11 
(11  
PropertyInfo11  ,
)11, -

expression11- 7
.117 8
Member118 >
;11> ?
var22 
target22 
=22 

Expression22 #
.22# $
Lambda22$ *
(22* +

expression22+ 5
.225 6

Expression226 @
)22@ A
.22A B
Compile22B I
(22I J
)22J K
.22K L
DynamicInvoke22L Y
(22Y Z
)22Z [
;22[ \
propertyInfo55 
.55 
SetValue55 !
(55! "
target55" (
,55( )
value55* /
)55/ 0
;550 1
}66 	
public@@ 
static@@ 
void@@ 
SetPropertyValue@@ +
<@@+ ,
TInput@@, 2
,@@2 3
T@@4 5
>@@5 6
(@@6 7
this@@7 ;

Expression@@< F
<@@F G
Func@@G K
<@@K L
TInput@@L R
,@@R S
T@@T U
>@@U V
>@@V W
lambda@@X ^
,@@^ _
TInput@@` f
input@@g l
,@@l m
T@@n o
value@@p u
)@@u v
{AA 	
varCC 

expressionCC 
=CC 
(CC 
lambdaCC $
asCC% '
LambdaExpressionCC( 8
)CC8 9
.CC9 :
BodyCC: >
asCC? A
MemberExpressionCCB R
;CCR S
varFF 
propertyInfoFF 
=FF 
(FF  
PropertyInfoFF  ,
)FF, -

expressionFF- 7
.FF7 8
MemberFF8 >
;FF> ?
propertyInfoII 
.II 
SetValueII !
(II! "
inputII" '
,II' (
valueII) .
)II. /
;II/ 0
}JJ 	
}KK 
}LL ‘
NJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\File\FileManager.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

class 
FileManager 
: 
IFileManager +
{ 
public 
async 
Task #
WriteAllTextToFileAsync 1
(1 2
string2 8
text9 =
,= >
string? E
pathF J
,J K
boolL P
appendQ W
=X Y
falseZ _
)_ `
{ 	
path 
= 
NormalizePath  
(  !
path! %
)% &
;& '
path 
= 
ResolvePath 
( 
path #
)# $
;$ %
await 
AsyncAwaiter 
. 

AwaitAsync )
() *
nameof* 0
(0 1
FileManager1 <
)< =
+> ?
path@ D
,D E
asyncF K
(L M
)M N
=>O Q
{ 
await 
CoreDI 
. 
Task !
.! "
Run" %
(% &
(& '
)' (
=>) +
{ 
using!! 
(!! 
var!! 

fileStream!! )
=!!* +
(!!, -

TextWriter!!- 7
)!!7 8
new!!8 ;
StreamWriter!!< H
(!!H I
File!!I M
.!!M N
Open!!N R
(!!R S
path!!S W
,!!W X
append!!Y _
?!!` a
FileMode!!b j
.!!j k
Append!!k q
:!!r s
FileMode!!t |
.!!| }
Create	!!} É
,
!!É Ñ

FileAccess
!!Ö è
.
!!è ê
Write
!!ê ï
)
!!ï ñ
)
!!ñ ó
)
!!ó ò

fileStream"" "
.""" #
Write""# (
(""( )
text"") -
)""- .
;"". /
}## 
)## 
;## 
}$$ 
)$$ 
;$$ 
}%% 	
public-- 
string-- 
NormalizePath-- #
(--# $
string--$ *
path--+ /
)--/ 0
{.. 	
if00 
(00 
RuntimeInformation00 "
.00" #
IsOSPlatform00# /
(00/ 0

OSPlatform000 :
.00: ;
Windows00; B
)00B C
)00C D
return22 
path22 
?22 
.22 
Replace22 $
(22$ %
$char22% (
,22( )
$char22* .
)22. /
.22/ 0
Trim220 4
(224 5
)225 6
;226 7
else44 
return66 
path66 
?66 
.66 
Replace66 $
(66$ %
$char66% )
,66) *
$char66+ .
)66. /
.66/ 0
Trim660 4
(664 5
)665 6
;666 7
}77 	
public>> 
string>> 
ResolvePath>> !
(>>! "
string>>" (
path>>) -
)>>- .
{?? 	
returnAA 
PathAA 
.AA 
GetFullPathAA #
(AA# $
pathAA$ (
)AA( )
;AA) *
}BB 	
}CC 
}DD ¸
VJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\Icons\IconTypeExtensions.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

static 
class 
IconTypeExtensions *
{ 
public 
static 
string 
ToFontAwesome *
(* +
this+ /
IconType0 8
type9 =
)= >
{ 	
switch 
( 
type 
) 
{ 
case 
IconType 
. 
File "
:" #
return 
$str #
;# $
case 
IconType 
. 
Picrure %
:% &
return 
$str #
;# $
default 
: 
return 
null 
;  
}   
}!! 	
}"" 
}## ≈
HJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\CoreDI.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{		 
public 

static 
class 
CoreDI 
{ 
public 
static 
IFileManager "
File# '
=>( *
	Framework+ 4
.4 5
Service5 <
<< =
IFileManager= I
>I J
(J K
)K L
;L M
public 
static 
ITaskManager "
Task# '
=>( *
	Framework+ 4
.4 5
Service5 <
<< =
ITaskManager= I
>I J
(J K
)K L
;L M
} 
} ¸
]J:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\Interfaces\IClientDataStore.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

	interface 
IClientDataStore %
{ 
Task  
EnsureDataStoreAsync !
(! "
)" #
;# $
Task 
< 
bool 
> 
HasCredentialsAsync &
(& '
)' (
;( )
Task 
< %
LoginCredentialsDataModel &
>& '$
GetLoginCredentialsAsync( @
(@ A
)A B
;B C
Task$$ %
SaveLoginCredentialsAsync$$ &
($$& '%
LoginCredentialsDataModel$$' @
loginCredentials$$A Q
)$$Q R
;$$R S
Task** )
ClearAllLoginCredentialsAsync** *
(*** +
)**+ ,
;**, -
}++ 
},, ‹
YJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\Interfaces\IFileManager.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public		 

	interface		 
IFileManager		 !
{

 
Task #
WriteAllTextToFileAsync $
($ %
string% +
text, 0
,0 1
string2 8
path9 =
,= >
bool? C
appendD J
=K L
falseM R
)R S
;S T
string 
NormalizePath 
( 
string #
path$ (
)( )
;) *
string!! 
ResolvePath!! 
(!! 
string!! !
path!!" &
)!!& '
;!!' (
}"" 
}## ≠
XJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\Interfaces\ILogFactory.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public		 

	interface		 
ILogFactory		  
{

 
LogFactoryLevel 
LogOutputLevel &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
bool #
IncludeLogOriginDetails $
{% &
get' *
;* +
set, /
;/ 0
}1 2
event 
Action 
< 
( 
string 
Message $
,$ %
LogLevel& .
Level/ 4
)4 5
>5 6
NewLog7 =
;= >
void)) 
	AddLogger)) 
()) 
ILogger)) 
logger)) %
)))% &
;))& '
void// 
RemoveLogger// 
(// 
ILogger// !
logger//" (
)//( )
;//) *
void99 
Log99 
(99 
string99 
message99 
,99  
LogLevel99! )
level99* /
=990 1
LogLevel992 :
.99: ;
Informative99; F
,99F G
[99H I
CallerMemberName99I Y
]99Y Z
string99[ a
origin99b h
=99i j
$str99k m
,99m n
[99o p
CallerFilePath99p ~
]99~ 
string
99Ä Ü
filePath
99á è
=
99ê ë
$str
99í î
,
99î ï
[
99ñ ó
CallerLineNumber
99ó ß
]
99ß ®
int
99© ¨

lineNumber
99≠ ∑
=
99∏ π
$num
99∫ ª
)
99ª º
;
99º Ω
}<< 
}== £6
YJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\Interfaces\ITaskManager.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{		 
public 

	interface 
ITaskManager !
{ 
void 
RunAndForget 
( 
Func 
< 
Task #
># $
function% -
,- .
[/ 0
CallerMemberName0 @
]@ A
stringB H
originI O
=P Q
$strR T
,T U
[V W
CallerFilePathW e
]e f
stringg m
filePathn v
=w x
$stry {
,{ |
[} ~
CallerLineNumber	~ é
]
é è
int
ê ì

lineNumber
î û
=
ü †
$num
° ¢
)
¢ £
;
£ §
Task)) 
Run)) 
()) 
Func)) 
<)) 
Task)) 
>)) 
function)) $
,))$ %
[))& '
CallerMemberName))' 7
]))7 8
string))9 ?
origin))@ F
=))G H
$str))I K
,))K L
[))M N
CallerFilePath))N \
]))\ ]
string))^ d
filePath))e m
=))n o
$str))p r
,))r s
[))t u
CallerLineNumber	))u Ö
]
))Ö Ü
int
))á ä

lineNumber
))ã ï
=
))ñ ó
$num
))ò ô
)
))ô ö
;
))ö õ
Task99 
<99 
TResult99 
>99 
Run99 
<99 
TResult99 !
>99! "
(99" #
Func99# '
<99' (
Task99( ,
<99, -
TResult99- 4
>994 5
>995 6
function997 ?
,99? @
CancellationToken99A R
cancellationToken99S d
,99d e
[99f g
CallerMemberName99g w
]99w x
string99y 
origin
99Ä Ü
=
99á à
$str
99â ã
,
99ã å
[
99ç é
CallerFilePath
99é ú
]
99ú ù
string
99û §
filePath
99• ≠
=
99Æ Ø
$str
99∞ ≤
,
99≤ ≥
[
99¥ µ
CallerLineNumber
99µ ≈
]
99≈ ∆
int
99«  

lineNumber
99À ’
=
99÷ ◊
$num
99ÿ Ÿ
)
99Ÿ ⁄
;
99⁄ €
TaskFF 
<FF 
TResultFF 
>FF 
RunFF 
<FF 
TResultFF !
>FF! "
(FF" #
FuncFF# '
<FF' (
TaskFF( ,
<FF, -
TResultFF- 4
>FF4 5
>FF5 6
functionFF7 ?
,FF? @
[FFA B
CallerMemberNameFFB R
]FFR S
stringFFT Z
originFF[ a
=FFb c
$strFFd f
,FFf g
[FFh i
CallerFilePathFFi w
]FFw x
stringFFy 
filePath
FFÄ à
=
FFâ ä
$str
FFã ç
,
FFç é
[
FFè ê
CallerLineNumber
FFê †
]
FF† °
int
FF¢ •

lineNumber
FF¶ ∞
=
FF± ≤
$num
FF≥ ¥
)
FF¥ µ
;
FFµ ∂
TaskWW 
<WW 
TResultWW 
>WW 
RunWW 
<WW 
TResultWW !
>WW! "
(WW" #
FuncWW# '
<WW' (
TResultWW( /
>WW/ 0
functionWW1 9
,WW9 :
CancellationTokenWW; L
cancellationTokenWWM ^
,WW^ _
[WW` a
CallerMemberNameWWa q
]WWq r
stringWWs y
origin	WWz Ä
=
WWÅ Ç
$str
WWÉ Ö
,
WWÖ Ü
[
WWá à
CallerFilePath
WWà ñ
]
WWñ ó
string
WWò û
filePath
WWü ß
=
WW® ©
$str
WW™ ¨
,
WW¨ ≠
[
WWÆ Ø
CallerLineNumber
WWØ ø
]
WWø ¿
int
WW¡ ƒ

lineNumber
WW≈ œ
=
WW– —
$num
WW“ ”
)
WW” ‘
;
WW‘ ’
Taskdd 
<dd 
TResultdd 
>dd 
Rundd 
<dd 
TResultdd !
>dd! "
(dd" #
Funcdd# '
<dd' (
TResultdd( /
>dd/ 0
functiondd1 9
,dd9 :
[dd; <
CallerMemberNamedd< L
]ddL M
stringddN T
originddU [
=dd\ ]
$strdd^ `
,dd` a
[ddb c
CallerFilePathddc q
]ddq r
stringdds y
filePath	ddz Ç
=
ddÉ Ñ
$str
ddÖ á
,
ddá à
[
ddâ ä
CallerLineNumber
ddä ö
]
ddö õ
int
ddú ü

lineNumber
dd† ™
=
dd´ ¨
$num
dd≠ Æ
)
ddÆ Ø
;
ddØ ∞
Taskss 
Runss 
(ss 
Funcss 
<ss 
Taskss 
>ss 
functionss $
,ss$ %
CancellationTokenss& 7
cancellationTokenss8 I
,ssI J
[ssK L
CallerMemberNamessL \
]ss\ ]
stringss^ d
originsse k
=ssl m
$strssn p
,ssp q
[ssr s
CallerFilePath	sss Å
]
ssÅ Ç
string
ssÉ â
filePath
ssä í
=
ssì î
$str
ssï ó
,
ssó ò
[
ssô ö
CallerLineNumber
ssö ™
]
ss™ ´
int
ss¨ Ø

lineNumber
ss∞ ∫
=
ssª º
$num
ssΩ æ
)
ssæ ø
;
ssø ¿
Task
ÇÇ 
Run
ÇÇ 
(
ÇÇ 
Action
ÇÇ 
action
ÇÇ 
,
ÇÇ 
CancellationToken
ÇÇ  1
cancellationToken
ÇÇ2 C
,
ÇÇC D
[
ÇÇE F
CallerMemberName
ÇÇF V
]
ÇÇV W
string
ÇÇX ^
origin
ÇÇ_ e
=
ÇÇf g
$str
ÇÇh j
,
ÇÇj k
[
ÇÇl m
CallerFilePath
ÇÇm {
]
ÇÇ{ |
stringÇÇ} É
filePathÇÇÑ å
=ÇÇç é
$strÇÇè ë
,ÇÇë í
[ÇÇì î 
CallerLineNumberÇÇî §
]ÇÇ§ •
intÇÇ¶ ©

lineNumberÇÇ™ ¥
=ÇÇµ ∂
$numÇÇ∑ ∏
)ÇÇ∏ π
;ÇÇπ ∫
Task
éé 
Run
éé 
(
éé 
Action
éé 
action
éé 
,
éé 
[
éé  !
CallerMemberName
éé! 1
]
éé1 2
string
éé3 9
origin
éé: @
=
ééA B
$str
ééC E
,
ééE F
[
ééG H
CallerFilePath
ééH V
]
ééV W
string
ééX ^
filePath
éé_ g
=
ééh i
$str
ééj l
,
éél m
[
één o
CallerLineNumber
ééo 
]éé Ä
intééÅ Ñ

lineNumberééÖ è
=ééê ë
$numééí ì
)ééì î
;ééî ï
}
èè 
}êê Ì
VJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\Logging\Core\ILogger.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

	interface 
ILogger 
{ 
void 
Log 
( 
string 
message 
,  
LogLevel! )
level* /
)/ 0
;0 1
} 
} £
^J:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\Logging\Core\LogFactoryLevel.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

enum 
LogFactoryLevel 
{ 
Debug 
= 
$num 
, 
Verbose 
= 
$num 
, 
Informative 
= 
$num 
, 
Critical 
= 
$num 
, 
Nothing 
= 
$num 
, 
}   
}!! ◊
WJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\Logging\Core\LogLevel.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

enum 
LogLevel 
{ 
Debug 
= 
$num 
, 
Verbose 
= 
$num 
, 
Informative 
= 
$num 
, 
Warning 
= 
$num 
, 
Error 
= 
$num 
, 
Success$$ 
=$$ 
$num$$ 
,$$ 
}%% 
}&& ﬁ)
gJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\Logging\Implementation\BaseLogFactory.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

class 
BaseLogFactory 
:  !
ILogFactory" -
{ 
	protected 
List 
< 
ILogger 
> 
mLoggers  (
=) *
new+ .
List/ 3
<3 4
ILogger4 ;
>; <
(< =
)= >
;> ?
	protected 
object 
mLoggersLock %
=& '
new( +
object, 2
(2 3
)3 4
;4 5
public"" 
LogFactoryLevel"" 
LogOutputLevel"" -
{"". /
get""0 3
;""3 4
set""5 8
;""8 9
}"": ;
public(( 
bool(( #
IncludeLogOriginDetails(( +
{((, -
get((. 1
;((1 2
set((3 6
;((6 7
}((8 9
=((: ;
true((< @
;((@ A
public11 
event11 
Action11 
<11 
(11 
string11 #
Message11$ +
,11+ ,
LogLevel11- 5
Level116 ;
)11; <
>11< =
NewLog11> D
=11E F
(11G H
details11H O
)11O P
=>11Q S
{11T U
}11V W
;11W X
public;; 
BaseLogFactory;; 
(;; 
ILogger;; %
[;;% &
];;& '
loggers;;( /
=;;0 1
null;;2 6
);;6 7
{<< 	
	AddLogger>> 
(>> 
new>> 
ConsoleLogger>> '
(>>' (
)>>( )
)>>) *
;>>* +
ifAA 
(AA 
loggersAA 
!=AA 
nullAA 
)AA  
foreachBB 
(BB 
varBB 
loggerBB #
inBB$ &
loggersBB' .
)BB. /
	AddLoggerCC 
(CC 
loggerCC $
)CC$ %
;CC% &
}DD 	
publicNN 
voidNN 
	AddLoggerNN 
(NN 
ILoggerNN %
loggerNN& ,
)NN, -
{OO 	
lockQQ 
(QQ 
mLoggersLockQQ 
)QQ 
{RR 
ifTT 
(TT 
!TT 
mLoggersTT 
.TT 
ContainsTT &
(TT& '
loggerTT' -
)TT- .
)TT. /
mLoggersVV 
.VV 
AddVV  
(VV  !
loggerVV! '
)VV' (
;VV( )
}WW 
}XX 	
public^^ 
void^^ 
RemoveLogger^^  
(^^  !
ILogger^^! (
logger^^) /
)^^/ 0
{__ 	
lockaa 
(aa 
mLoggersLockaa 
)aa 
{bb 
ifdd 
(dd 
mLoggersdd 
.dd 
Containsdd %
(dd% &
loggerdd& ,
)dd, -
)dd- .
mLoggersff 
.ff 
Removeff #
(ff# $
loggerff$ *
)ff* +
;ff+ ,
}gg 
}hh 	
publicrr 
voidrr 
Logrr 
(rr 
stringss 
messagess 
,ss 
LogLeveltt 
leveltt 
=tt 
LogLeveltt %
.tt% &
Informativett& 1
,tt1 2
[uu 
CallerMemberNameuu 
]uu 
stringuu %
originuu& ,
=uu- .
$struu/ 1
,uu1 2
[vv 
CallerFilePathvv 
]vv 
stringvv #
filePathvv$ ,
=vv- .
$strvv/ 1
,vv1 2
[ww 
CallerLineNumberww 
]ww 
intww "

lineNumberww# -
=ww. /
$numww0 1
)ww1 2
{xx 	
ifzz 
(zz 
(zz 
intzz 
)zz 
levelzz 
<zz 
(zz 
intzz !
)zz! "
LogOutputLevelzz" 0
)zz0 1
return{{ 
;{{ 
if~~ 
(~~ #
IncludeLogOriginDetails~~ '
)~~' (
message 
= 
$" 
{ 
message $
}$ %
 [% '
{' (
Path( ,
., -
GetFileName- 8
(8 9
filePath9 A
)A B
}B C
 > C F
{F G
originG M
}M N
() > N S
{S T

lineNumberT ^
}^ _
]_ `
"` a
;a b
mLoggers
ÇÇ 
.
ÇÇ 
ForEach
ÇÇ 
(
ÇÇ 
logger
ÇÇ #
=>
ÇÇ$ &
logger
ÇÇ' -
.
ÇÇ- .
Log
ÇÇ. 1
(
ÇÇ1 2
message
ÇÇ2 9
,
ÇÇ9 :
level
ÇÇ; @
)
ÇÇ@ A
)
ÇÇA B
;
ÇÇB C
NewLog
ÖÖ 
.
ÖÖ 
Invoke
ÖÖ 
(
ÖÖ 
(
ÖÖ 
message
ÖÖ "
,
ÖÖ" #
level
ÖÖ$ )
)
ÖÖ) *
)
ÖÖ* +
;
ÖÖ+ ,
}
ÜÜ 	
}
ââ 
}ää ®
fJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\Logging\Implementation\ConsoleLogger.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

class 
ConsoleLogger 
:  
ILogger! (
{		 
public 
void 
Log 
( 
string 
message &
,& '
LogLevel( 0
level1 6
)6 7
{ 	
var 
consoleOldColor 
=  !
Console" )
.) *
ForegroundColor* 9
;9 :
var 
consoleColor 
= 
ConsoleColor +
.+ ,
White, 1
;1 2
switch 
( 
level 
) 
{ 
case 
LogLevel 
. 
Debug #
:# $
consoleColor  
=! "
ConsoleColor# /
./ 0
Blue0 4
;4 5
break 
; 
case   
LogLevel   
.   
Verbose   %
:  % &
consoleColor!!  
=!!! "
ConsoleColor!!# /
.!!/ 0
Gray!!0 4
;!!4 5
break"" 
;"" 
case%% 
LogLevel%% 
.%% 
Warning%% %
:%%% &
consoleColor&&  
=&&! "
ConsoleColor&&# /
.&&/ 0

DarkYellow&&0 :
;&&: ;
break'' 
;'' 
case** 
LogLevel** 
.** 
Error** #
:**# $
consoleColor++  
=++! "
ConsoleColor++# /
.++/ 0
Red++0 3
;++3 4
break,, 
;,, 
case// 
LogLevel// 
.// 
Success// %
://% &
consoleColor00  
=00! "
ConsoleColor00# /
.00/ 0
Green000 5
;005 6
break11 
;11 
}22 
Console55 
.55 
ForegroundColor55 #
=55$ %
consoleColor55& 2
;552 3
Console66 
.66 
Write66 
(66 
$"66 
[66 
{66 
level66 #
}66# $
]66$ %
"66% &
.66& '
PadRight66' /
(66/ 0
$num660 2
,662 3
$char664 7
)667 8
)668 9
;669 :
Console77 
.77 
ForegroundColor77 #
=77$ %
consoleOldColor77& 5
;775 6
Console:: 
.:: 
	WriteLine:: 
(:: 
message:: %
)::% &
;::& '
};; 	
}<< 
}== Á
cJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\IoC\Logging\Implementation\FileLogger.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public

 

class

 

FileLogger

 
:

 
ILogger

 %
{ 
public 
string 
FilePath 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
bool 
LogTime 
{ 
get !
;! "
set# &
;& '
}( )
=* +
true, 0
;0 1
public   

FileLogger   
(   
string    
filePath  ! )
)  ) *
{!! 	
FilePath"" 
="" 
filePath"" 
;""  
}## 	
public.. 
void.. 
Log.. 
(.. 
string.. 
message.. &
,..& '
LogLevel..( 0
level..1 6
)..6 7
{// 	
var11 
currentTime11 
=11 
DateTimeOffset11 ,
.11, -
Now11- 0
.110 1
ToString111 9
(119 :
$str11: O
)11O P
;11P Q
var44 
timeLogString44 
=44 
LogTime44  '
?44( )
$"44* ,
[44, -
{44- .
currentTime44. 9
}449 :
] 44: <
"44< =
:44> ?
string44@ F
.44F G
Empty44G L
;44L M
CoreDI77 
.77 
File77 
.77 #
WriteAllTextToFileAsync77 /
(77/ 0
$"770 2
{772 3
timeLogString773 @
}77@ A
{77A B
message77B I
}77I J
{77J K
Environment77K V
.77V W
NewLine77W ^
}77^ _
"77_ `
,77` a
FilePath77b j
,77j k
append77l r
:77r s
true77t x
)77x y
;77y z
}88 	
};; 
}<< Â
NJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\Routes\ApiRoutes.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public 

static 
class 
	ApiRoutes !
{ 
public 
const 
string 
Register $
=% &
$str' 5
;5 6
public 
const 
string 
Login !
=" #
$str$ /
;/ 0
public   
const   
string   
VerifyEmail   '
=  ( )
$str  * R
;  R S
public%% 
const%% 
string%% 
GetUserProfile%% *
=%%+ ,
$str%%- ?
;%%? @
public** 
const** 
string** 
UpdateUserProfile** -
=**. /
$str**0 I
;**I J
public// 
const// 
string// 
UpdateUserPassword// .
=/// 0
$str//1 L
;//L M
}00 
}11 ó
QJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\Routes\RouteHelpers.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{		 
public 

static 
class 
RouteHelpers $
{ 
public 
static 
string 
Host !
=" #
Configuration$ 1
[1 2
$str2 M
]M N
;N O
public 
static 
string 
GetAbsoluteRoute -
(- .
string. 4
relativeUrl5 @
)@ A
{ 	
var 
host 
= 
Host 
; 
if 
( 
string 
. 
IsNullOrEmpty $
($ %
relativeUrl% 0
)0 1
)1 2
return   
host   
;   
if## 
(## 
!## 
relativeUrl## 
.## 

StartsWith## '
(##' (
$str##( +
)##+ ,
)##, -
relativeUrl%% 
=%% 
$"%%  
/%%  !
{%%! "
relativeUrl%%" -
}%%- .
"%%. /
;%%/ 0
return(( 
host(( 
+(( 
relativeUrl(( %
;((% &
})) 	
}** 
}++ ”
YJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\Security\SecureStringHelper.cs
	namespace 	
Fasetto
 
. 
Word 
. 
Core 
{ 
public

 

static

 
class

 
SecureStringHelper

 *
{ 
public 
static 
string 
Unsecure %
(% &
this& *
SecureString+ 7
securePassword8 F
)F G
{ 	
if 
( 
securePassword 
== !
null" &
)& '
return 
string 
. 
Empty #
;# $
var 
unmanagedString 
=  !
IntPtr" (
.( )
Zero) -
;- .
try 
{ 
unmanagedString 
=  !
Marshal" )
.) *,
 SecureStringToGlobalAllocUnicode* J
(J K
securePasswordK Y
)Y Z
;Z [
return 
Marshal 
. 
PtrToStringUni -
(- .
unmanagedString. =
)= >
;> ?
} 
finally   
{!! 
Marshal## 
.## &
ZeroFreeGlobalAllocUnicode## 2
(##2 3
unmanagedString##3 B
)##B C
;##C D
}$$ 
}%% 	
}&& 
}'' ‘o
NJ:\Designs09\WpfDesigns\src\Fasetto.Word\Fasetto.Word.Core\Task\TaskManager.cs
	namespace		 	
Fasetto		
 
.		 
Word		 
.		 
Core		 
{

 
public 

class 
TaskManager 
: 
ITaskManager +
{ 
public 
async 
void 
RunAndForget &
(& '
Func' +
<+ ,
Task, 0
>0 1
function2 :
,: ;
[< =
CallerMemberName= M
]M N
stringO U
originV \
=] ^
$str_ a
,a b
[c d
CallerFilePathd r
]r s
stringt z
filePath	{ É
=
Ñ Ö
$str
Ü à
,
à â
[
ä ã
CallerLineNumber
ã õ
]
õ ú
int
ù †

lineNumber
° ´
=
¨ ≠
$num
Æ Ø
)
Ø ∞
{ 	
await 
Run 
( 
function 
, 
origin  &
,& '
filePath( 0
,0 1

lineNumber2 <
)< =
;= >
} 	
public 
async 
Task 
Run 
( 
Func "
<" #
Task# '
>' (
function) 1
,1 2
[3 4
CallerMemberName4 D
]D E
stringF L
originM S
=T U
$strV X
,X Y
[Z [
CallerFilePath[ i
]i j
stringk q
filePathr z
={ |
$str} 
,	 Ä
[
Å Ç
CallerLineNumber
Ç í
]
í ì
int
î ó

lineNumber
ò ¢
=
£ §
$num
• ¶
)
¶ ß
{ 	
try 
{ 
await 
Task 
. 
Run 
( 
function '
)' (
;( )
} 
catch 
( 
	Exception 
ex 
)  
{ 
FrameworkDI 
. 
Logger "
." #
LogErrorSource# 1
(1 2
ex2 4
.4 5
ToString5 =
(= >
)> ?
,? @
originA G
:G H
originI O
,O P
filePathQ Y
:Y Z
filePath[ c
,c d

lineNumbere o
:o p

lineNumberq {
){ |
;| }
throw   
;   
}!! 
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ 
TResult$$ !
>$$! "
Run$$# &
<$$& '
TResult$$' .
>$$. /
($$/ 0
Func$$0 4
<$$4 5
Task$$5 9
<$$9 :
TResult$$: A
>$$A B
>$$B C
function$$D L
,$$L M
CancellationToken$$N _
cancellationToken$$` q
,$$q r
[$$s t
CallerMemberName	$$t Ñ
]
$$Ñ Ö
string
$$Ü å
origin
$$ç ì
=
$$î ï
$str
$$ñ ò
,
$$ò ô
[
$$ö õ
CallerFilePath
$$õ ©
]
$$© ™
string
$$´ ±
filePath
$$≤ ∫
=
$$ª º
$str
$$Ω ø
,
$$ø ¿
[
$$¡ ¬
CallerLineNumber
$$¬ “
]
$$“ ”
int
$$‘ ◊

lineNumber
$$ÿ ‚
=
$$„ ‰
$num
$$Â Ê
)
$$Ê Á
{%% 	
try&& 
{'' 
return(( 
await(( 
Task(( !
.((! "
Run((" %
(((% &
function((& .
,((. /
cancellationToken((0 A
)((A B
;((B C
})) 
catch** 
(** 
	Exception** 
ex** 
)**  
{++ 
FrameworkDI-- 
.-- 
Logger-- "
.--" #
LogErrorSource--# 1
(--1 2
ex--2 4
.--4 5
ToString--5 =
(--= >
)--> ?
,--? @
origin--A G
:--G H
origin--I O
,--O P
filePath--Q Y
:--Y Z
filePath--[ c
,--c d

lineNumber--e o
:--o p

lineNumber--q {
)--{ |
;--| }
throw00 
;00 
}11 
}22 	
public44 
async44 
Task44 
<44 
TResult44 !
>44! "
Run44# &
<44& '
TResult44' .
>44. /
(44/ 0
Func440 4
<444 5
Task445 9
<449 :
TResult44: A
>44A B
>44B C
function44D L
,44L M
[44N O
CallerMemberName44O _
]44_ `
string44a g
origin44h n
=44o p
$str44q s
,44s t
[44u v
CallerFilePath	44v Ñ
]
44Ñ Ö
string
44Ü å
filePath
44ç ï
=
44ñ ó
$str
44ò ö
,
44ö õ
[
44ú ù
CallerLineNumber
44ù ≠
]
44≠ Æ
int
44Ø ≤

lineNumber
44≥ Ω
=
44æ ø
$num
44¿ ¡
)
44¡ ¬
{55 	
try66 
{77 
return88 
await88 
Task88 !
.88! "
Run88" %
(88% &
function88& .
)88. /
;88/ 0
}99 
catch:: 
(:: 
	Exception:: 
ex:: 
)::  
{;; 
FrameworkDI== 
.== 
Logger== "
.==" #
LogErrorSource==# 1
(==1 2
ex==2 4
.==4 5
ToString==5 =
(=== >
)==> ?
,==? @
origin==A G
:==G H
origin==I O
,==O P
filePath==Q Y
:==Y Z
filePath==[ c
,==c d

lineNumber==e o
:==o p

lineNumber==q {
)=={ |
;==| }
throw@@ 
;@@ 
}AA 
}BB 	
publicDD 
asyncDD 
TaskDD 
<DD 
TResultDD !
>DD! "
RunDD# &
<DD& '
TResultDD' .
>DD. /
(DD/ 0
FuncDD0 4
<DD4 5
TResultDD5 <
>DD< =
functionDD> F
,DDF G
CancellationTokenDDH Y
cancellationTokenDDZ k
,DDk l
[DDm n
CallerMemberNameDDn ~
]DD~ 
string
DDÄ Ü
origin
DDá ç
=
DDé è
$str
DDê í
,
DDí ì
[
DDî ï
CallerFilePath
DDï £
]
DD£ §
string
DD• ´
filePath
DD¨ ¥
=
DDµ ∂
$str
DD∑ π
,
DDπ ∫
[
DDª º
CallerLineNumber
DDº Ã
]
DDÃ Õ
int
DDŒ —

lineNumber
DD“ ‹
=
DD› ﬁ
$num
DDﬂ ‡
)
DD‡ ·
{EE 	
tryFF 
{GG 
returnHH 
awaitHH 
TaskHH !
.HH! "
RunHH" %
(HH% &
functionHH& .
,HH. /
cancellationTokenHH0 A
)HHA B
;HHB C
}II 
catchJJ 
(JJ 
	ExceptionJJ 
exJJ 
)JJ  
{KK 
FrameworkDIMM 
.MM 
LoggerMM "
.MM" #
LogErrorSourceMM# 1
(MM1 2
exMM2 4
.MM4 5
ToStringMM5 =
(MM= >
)MM> ?
,MM? @
originMMA G
:MMG H
originMMI O
,MMO P
filePathMMQ Y
:MMY Z
filePathMM[ c
,MMc d

lineNumberMMe o
:MMo p

lineNumberMMq {
)MM{ |
;MM| }
throwPP 
;PP 
}QQ 
}RR 	
publicTT 
asyncTT 
TaskTT 
<TT 
TResultTT !
>TT! "
RunTT# &
<TT& '
TResultTT' .
>TT. /
(TT/ 0
FuncTT0 4
<TT4 5
TResultTT5 <
>TT< =
functionTT> F
,TTF G
[TTH I
CallerMemberNameTTI Y
]TTY Z
stringTT[ a
originTTb h
=TTi j
$strTTk m
,TTm n
[TTo p
CallerFilePathTTp ~
]TT~ 
string
TTÄ Ü
filePath
TTá è
=
TTê ë
$str
TTí î
,
TTî ï
[
TTñ ó
CallerLineNumber
TTó ß
]
TTß ®
int
TT© ¨

lineNumber
TT≠ ∑
=
TT∏ π
$num
TT∫ ª
)
TTª º
{UU 	
tryVV 
{WW 
returnXX 
awaitXX 
TaskXX !
.XX! "
RunXX" %
(XX% &
functionXX& .
)XX. /
;XX/ 0
}YY 
catchZZ 
(ZZ 
	ExceptionZZ 
exZZ 
)ZZ  
{[[ 
FrameworkDI]] 
.]] 
Logger]] "
.]]" #
LogErrorSource]]# 1
(]]1 2
ex]]2 4
.]]4 5
ToString]]5 =
(]]= >
)]]> ?
,]]? @
origin]]A G
:]]G H
origin]]I O
,]]O P
filePath]]Q Y
:]]Y Z
filePath]][ c
,]]c d

lineNumber]]e o
:]]o p

lineNumber]]q {
)]]{ |
;]]| }
throw`` 
;`` 
}aa 
}bb 	
publicdd 
asyncdd 
Taskdd 
Rundd 
(dd 
Funcdd "
<dd" #
Taskdd# '
>dd' (
functiondd) 1
,dd1 2
CancellationTokendd3 D
cancellationTokenddE V
,ddV W
[ddX Y
CallerMemberNameddY i
]ddi j
stringddk q
originddr x
=ddy z
$strdd{ }
,dd} ~
[	dd Ä
CallerFilePath
ddÄ é
]
ddé è
string
ddê ñ
filePath
ddó ü
=
dd† °
$str
dd¢ §
,
dd§ •
[
dd¶ ß
CallerLineNumber
ddß ∑
]
dd∑ ∏
int
ddπ º

lineNumber
ddΩ «
=
dd» …
$num
dd  À
)
ddÀ Ã
{ee 	
tryff 
{gg 
awaithh 
Taskhh 
.hh 
Runhh 
(hh 
functionhh '
,hh' (
cancellationTokenhh) :
)hh: ;
;hh; <
}ii 
catchjj 
(jj 
	Exceptionjj 
exjj 
)jj  
{kk 
FrameworkDImm 
.mm 
Loggermm "
.mm" #
LogErrorSourcemm# 1
(mm1 2
exmm2 4
.mm4 5
ToStringmm5 =
(mm= >
)mm> ?
,mm? @
originmmA G
:mmG H
originmmI O
,mmO P
filePathmmQ Y
:mmY Z
filePathmm[ c
,mmc d

lineNumbermme o
:mmo p

lineNumbermmq {
)mm{ |
;mm| }
throwpp 
;pp 
}qq 
}rr 	
publictt 
asynctt 
Tasktt 
Runtt 
(tt 
Actiontt $
actiontt% +
,tt+ ,
CancellationTokentt- >
cancellationTokentt? P
,ttP Q
[ttR S
CallerMemberNamettS c
]ttc d
stringtte k
originttl r
=tts t
$strttu w
,ttw x
[tty z
CallerFilePath	ttz à
]
ttà â
string
ttä ê
filePath
ttë ô
=
ttö õ
$str
ttú û
,
ttû ü
[
tt† °
CallerLineNumber
tt° ±
]
tt± ≤
int
tt≥ ∂

lineNumber
tt∑ ¡
=
tt¬ √
$num
ttƒ ≈
)
tt≈ ∆
{uu 	
tryvv 
{ww 
awaitxx 
Taskxx 
.xx 
Runxx 
(xx 
actionxx %
,xx% &
cancellationTokenxx' 8
)xx8 9
;xx9 :
}yy 
catchzz 
(zz 
	Exceptionzz 
exzz 
)zz  
{{{ 
FrameworkDI}} 
.}} 
Logger}} "
.}}" #
LogErrorSource}}# 1
(}}1 2
ex}}2 4
.}}4 5
ToString}}5 =
(}}= >
)}}> ?
,}}? @
origin}}A G
:}}G H
origin}}I O
,}}O P
filePath}}Q Y
:}}Y Z
filePath}}[ c
,}}c d

lineNumber}}e o
:}}o p

lineNumber}}q {
)}}{ |
;}}| }
throw
ÄÄ 
;
ÄÄ 
}
ÅÅ 
}
ÇÇ 	
public
ÑÑ 
async
ÑÑ 
Task
ÑÑ 
Run
ÑÑ 
(
ÑÑ 
Action
ÑÑ $
action
ÑÑ% +
,
ÑÑ+ ,
[
ÑÑ- .
CallerMemberName
ÑÑ. >
]
ÑÑ> ?
string
ÑÑ@ F
origin
ÑÑG M
=
ÑÑN O
$str
ÑÑP R
,
ÑÑR S
[
ÑÑT U
CallerFilePath
ÑÑU c
]
ÑÑc d
string
ÑÑe k
filePath
ÑÑl t
=
ÑÑu v
$str
ÑÑw y
,
ÑÑy z
[
ÑÑ{ |
CallerLineNumberÑÑ| å
]ÑÑå ç
intÑÑé ë

lineNumberÑÑí ú
=ÑÑù û
$numÑÑü †
)ÑÑ† °
{
ÖÖ 	
try
ÜÜ 
{
áá 
await
àà 
Task
àà 
.
àà 
Run
àà 
(
àà 
action
àà %
)
àà% &
;
àà& '
}
ââ 
catch
ää 
(
ää 
	Exception
ää 
ex
ää 
)
ää  
{
ãã 
FrameworkDI
çç 
.
çç 
Logger
çç "
.
çç" #
LogErrorSource
çç# 1
(
çç1 2
ex
çç2 4
.
çç4 5
ToString
çç5 =
(
çç= >
)
çç> ?
,
çç? @
origin
ççA G
:
ççG H
origin
ççI O
,
ççO P
filePath
ççQ Y
:
ççY Z
filePath
çç[ c
,
ççc d

lineNumber
ççe o
:
çço p

lineNumber
ççq {
)
çç{ |
;
çç| }
throw
êê 
;
êê 
}
ëë 
}
íí 	
}
ïï 
}ññ 