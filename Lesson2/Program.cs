
byte a1 = 100;
byte b1 = 25;
byte c1 = (byte)(a1 + b1); // 125
byte c2 = (byte)(a1 - b1); // 75
byte c3 = (byte)(a1 * b1); // 2500 - 256 * 9 = 196
byte c4 = (byte)(a1 / b1); // 4
int c5 = (int)(a1 + b1);   //125
int c6 = (int)(255f + 5d); //260

sbyte a2 = 120;
sbyte b2 = -60;
sbyte d1 = (sbyte)(a2 + b2); // 60
sbyte d2 = (sbyte)(a2 - b2); // 120-(-60)=180 180-128=52 52-128=-76
sbyte d3 = (sbyte)(a2 * b2); // 120*(-60)=-7200 -7200+128*56=-32
sbyte d4 = (sbyte)(a2 / b2); // -2
byte d5 = (byte)(a2 + b2);   // 60
byte d6 = (byte)(50d + 25u);    //75

short a3 = 420;
short b3 = 30;
short e1 = (short)(a3 + b3); // 450
short e2 = (short)(a3 - b3); // 390
short e3 = (short)(a3 * b3); // 12600
short e4 = (short)(a3 / b3); // 14
int e5 = (int)(a3 + b3);     // 450
int e6 = (int)(25l + 50d);   //75

ushort a4 = 600;
ushort b4 = 355;
ushort f1 = (ushort)(a4 + b4); // 955
ushort f2 = (ushort)(a4 - b4); // 245
ushort f3 = (ushort)(a4 * b4); // 213.000-3*65535=16395
ushort f4 = (ushort)(a4 / b4); // 1
byte f5 = (byte)(a4 + b4);     //955-3*256=187
byte f6 = (byte)(120ul + 50m); //170

int a5 = -550;
int b5 = 900;
int g1 = a5 + b5;                 // 350
int g2 = a5 - b5;                 // -1450
int g3 = a5 * b5;                 // -495.000
int g4 = a5 / b5;                 // 0
ushort g5 = (ushort)(a5 - b5);    // 65536-1450=64086
ushort g6 = (ushort)(50f + 1200); // 1250

uint a6 = 1080;
uint b6 = 360;
uint h1 = a6 + b6;               // 1440 
uint h2 = a6 - b6;               // 720
uint h3 = a6 * b6;               // 388800
uint h4 = a6 / b6;               // 3
ushort h5 = (ushort)(a6 * b6);   // 388800-5*65536=61120
ushort h6 = (ushort)(35l + 340); // 375

float a7 = -3960;
float b7 = -9300;
float i1 = a7 + b7;            // -13260
float i2 = a7 - b7;            // 5340
float i3 = a7 * b7;            // 36.828.000 <=> 3.6828E+07
float i4 = a7 / b7;            // 0.425806463
sbyte i5 = (sbyte)(a7 * b7);   // 36.828.000-128*287.718=96
sbyte i6 = (sbyte)(12f + 20d); // 32

double a8 = 9300;
double b8 = -300;
double j1 = a8 + b8;         // 9000
double j2 = a8 - b8;         // 9600
double j3 = a8 * b8;         // -2.790.000
double j4 = a8 / b8;         // -31
char j5 = (char)(a8 / b8);   // 65505'￡'
char j6 = (char)(25d + 400); // 425'Ʃ'

decimal a9 = -1260;
decimal b9 = 630;
decimal k1 = a9 + b9;             // -630
decimal k2 = a9 - b9;             // -1890
decimal k3 = a9 * b9;             // -793800
decimal k4 = a9 / b9;             // -2
float k5 = (float)(a9 * b9);      //793800
float k6 = (float)(360l + 800ul); //1160

char a10 = 'a';
char b10 = 'b';
char l1 = (char)(a10 + b10); // 195'Ã'
char l2 = (char)(a10 - b10); // 65535'\uffff'
char l3 = (char)(a10 * b10); // 9506'┢'
char l4 = (char)(a10 / b10); // 0'\0'
int l5 = (int)(a10 + b10);   // 195
int l6 = (int)(50f + 650l);  // 700

long a14 = 500;
long b14 = -250;
long p1 = (long)(a14 + b14);    //250
long p2 = (long)(a14 - b14);    //750
long p3 = (long)(a14 * b14);    //-125000
long p4 = (long)(a14 / b14);    //-2
float p5 = (float)(a14 + a14);  //500
float p6 = (float)(250 + 456d); // 706

bool a11 = false;
bool b11 = true;
// bool m1 = (bool)(a11 + b11);
// char m2 = (char)(a11 + b11);

object a12 = null;
object b12 = null;
// object n1 = (object)(a12 + b12);
// int n2 = (int)(a12 + b12);

string a13 = "aaa";
string b13 = "ddd";
string o1 = a13 + b13;                   //aaaddd
string o2 = a13.Replace("aaa", "sss"); //sss
string o3 = a13.Remove(2);

Console.ReadKey();