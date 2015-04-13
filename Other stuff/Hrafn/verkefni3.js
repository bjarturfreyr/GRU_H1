// Dæmi 1
var objectlol = {
	litur: 'Gulur',
	aldur: 19,
	prentari: function() {
		return this.litur + ' ' + this.aldur;
	}
}
// Dæmi 2
objectlol.litur = 'svartur';
// Dæmi 3
function litaobject (color, age) {
	this.color = color;
	this.age = age;
	this.skodaliti = function() {
		return this.color + ' ' + this.age
	};
}
var gummi = new litaobject('blue', 21);
var joi = new litaobject('red', 19);
var steinsi = new litaobject('purple', 7);
var dagur = new litaobject('yellow', 18);
var krilli = new litaobject('brown', 5);
// Dæmi 4
function litaobject (color, age, size) {
	this.color = color;
	this.age = age;
	this.size = size;
	this.skodaliti = function() {
		return this.color + ' ' + this.age + ' ' + this.size
	};
}
var frida = new litaobject('white', 17, 134);
/* Dæmi 5
'This' er vanalega notað inn í objectum eða functionum. this.breyta32 nær í
breytuna numer 32 sem að er inn i objecti en ef við notuðum objectcolor.breyta32
þá er hætta á að objectcolor sé til í eitthverjum öðrum texta og þá gæti komið villa
en 'this' nær bara í hluti sem að eru inn í objectinu eða functionunni
*/

// Dæmi 6
var fylkisuppskrift = ['sykur', 'hveiti', 'egg', 'mjolk', 'vatn'];
for (var i = 0; i < fylkisuppskrift.length; i++) {
	console.log(fylkisuppskrift[i])
};

var objectuppskrift = {
	hraefni1: 'sykur',
	hraefni2: 'hveiti',
	hraefni3: 'egg',
	hraefni4: 'mjolk',
	hraefni5: 'vatn'
}

for(var hraefni in objectuppskrift)
{
	console.log(hraefni)
};
// dæmi 7
NaN er built in object sem þíðir "Not an Number"
isNaN(string); //true
123 = NaN //false

infinity og -infinity eru built in object sem að displaya stærstu mögulegu
töluna og minnstu mögulegu töluna infinity === 1.7976931348623157E+10308 //true
-infinity === -1.7976931348623157E+10308 //true

undefined er er built in object sem að skoðar hvort sé búið að tilgreina breytur
var hrafn;
if (hrafn === undefined) {
	txt = "hrafn er ekki tilgreindur!";
}
else{
	txt = "hrafn er tilgreindur";
};

//Dæmi 8
/* The scr i pt is placed i nside an immediately invoked function expression
which helps prot ect the scope of variab les - skiptan er sett í immediately invoked function sem
að sér um að haldu um svæði breytanna */
-(function() {
// PART ONE : CREATE HOTEL OBJECT AND WRITE OUT THE OFFER DETAILS - búa til hotel object og skrifa út upplýsingar
// Create a hotel obj ect using object l i t eral syntax -- býr til hotel object með object literal syntax, þegar maður tilgreinir strax gildin
var hotel = {
name: 'Park',
roomRate: 240, // Amount in dollars - upphæð í dollurum
discount : 15, // Percentage di scount - prósentu afsláttur
offerPrice: function() {
var offerRate = this .roomRate * ((100 - this .discount) I 100);
return offerRate;
// Wr ite out the hotel name, standard rate, and the special rate - skrifar út nafnið, staðal hlutafall og sérstaka hlutafllið
var hotel Name, roomRate, specialRate; // Declare variables // býr til breytur
hotelName = document .getElementByid('hotelName');
roomRate = document.getElementByid('roomRate');
specialRate = document .getElementByld('specialRate');
// Get el ement s - nær í þættina og setur þá í text content
hotelName.textContent = hotel .name; // Write hotel name - skrifar hótel nafnið
roomRate.textContent = '$ ' + hotel . roomRate .toFixed(2) ; // Write room rate - skrifar herbergis hlutafll
specialRate .textContent = '$' +hotel .offerPrice(); // Write offer pri ce - skrifar verð tilboð

var expiryMsg; // Message displ ayed t o users - skilaboð til notanda
var today ; // Today's date - dagsetning
var el Ends ; // The element that shows the mes sage about the offer endi ng - þátturinn sem að sýnir skilaboðin í endirinn
function of fer Expires (today) {
// Decl are variables within the functi on for l ocal scope - býr til breytu í local scope(bara hægt að nota breyturnar inní function)
var weekFromToday, day, date, month, year, dayNames, monthNames;
// Add 7 days time (added in mi l li seconds) - bætir við 7 dögum í millisekúndum
weekFromToday =new Dat e(today .getTi me () + 7 * 24 * 60 * 60 * 1000) ;
// Create arrays to hold t he names of days I months - býr till fylki fyrir daga og mánuði
dayNames = [ ' Sunday' , ' Monday' , 'Tuesday ' , 'Wednesday ', 'Thursday' ,
0 ' Friday', 'Saturday ' ] ;
mont hNames =[' January', ' Februa ry', 'March', ' Apri l ', 'May ' , ' June ' ,
0 ' Jul y' , 'August ' , 'September' , 'October' , ' November' , 'December ' ] ;
// Collect the parts of the date to show on t he page - nær í hlutana sem að er partur af dagsetningunni
day = dayNames [weekFromToday . getOay ()];
date= weekFromToday .getOate();
month= mont hNames[weekFromToday.getMonth()] ;
year= weekFromToday .getFullYear() ;
// Create the message - býr til skilaboðin
expi ryMsg = 'Offer expires next ' ;
expi ryMsg += day + ' <br I>( ' +date+ ' ' +month+ ' ' +year + ')';
retu rn expiryMsg;
today= new Date() ;
elEnds = document .getEl ementByid( 'off erEnds');
elEnds .i nnerHTML = offe rExpires(today) ;
// Put today's date in vari able - setur daginn í dag í breytu
// Get t he offe r Ends el ement - setur enda skilaboð í element
// Add t he expi ry message - bætir við útrennings skilaboðum
// Finish the immediately i nvoked functi on exp ression - lokar immediately invoked fúnkunni
} () ) ;

