#define del 500
#define mic A0


int soglia = 65;
int cont = 0;
bool stato = 0;
int calc = 0;


void setup() {
  pinMode(mic,INPUT); //in del microfono
  Serial.begin(9600);

}

void controlla()
{
  if(stato = 0)
  {
  Serial.print("p"); //spegne 
  }
  if(stato = 1)
  {
    Serial.print("P"); //accende
    calc = 2;
  }
}

void cambioCanzone(){
  cont = 0;
  if(analogRead(mic)>soglia){
    cont++;
    delay(del);
  }
  
  if(cont == 3 ){
    Serial.print("C");
    cont = 0;
  }
  if(cont == 4 ){
    Serial.print("p");
    calc = 0;
  }
}

void loop() {
if(calc == 0){
  
  if(Serial.available()){
    if(Serial.read() == 'w'){
      controlla();
    }
  }

    if(analogRead(mic)>soglia){
    cont++;
    delay(del);
    }
  if(cont == 2 ){
    stato = !stato;
    cont = 0;
  }

  
}
   if(calc == 2){
    cambioCanzone();
   }
   
}
