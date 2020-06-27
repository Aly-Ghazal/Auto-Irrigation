#define temp A3
#define soil A1
#define water A2
#define pump 2
#define fan 5
void setup() {
  // put your setup code here, to run once:

pinMode(soil,INPUT);
pinMode(temp,INPUT);
pinMode(water,INPUT);
pinMode(fan,OUTPUT);
pinMode(pump,OUTPUT);
Serial.begin(9600);
}

void loop() {
/*int temp_deg=analogRead(temp);
temp_deg=temp_deg*0.48828125;*/
int soilRead=analogRead(soil);
/*int waterRead=analogRead(water);*/
/*temp_deg=map(temp_deg,0,1023,0,100);*/
soilRead=map(soilRead,0,1023,0,100);
/*waterRead=map(waterRead,0,1023,0,100);*/
//Checking of temp,soil moisture and water level
Serial.print(soilRead);
delay(1000);
/*if(soilRead<200)
{
 digitalWrite(pump,HIGH);
}
else
 digitalWrite(pump,LOW);
 if (temp_deg>100)
 {
  
 digitalWrite(fan,HIGH);
 }
else
{
 digitalWrite(fan,LOW);
 }*/
}
  // printing information

/*Serial.print(" ");
Serial.print(soilRead);
Serial.print(" ");
Serial.println(waterRead);
Serial.print(" ");
Serial.println(temp);
delay(1000);*/
