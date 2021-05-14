#define del 500
#define mic A0


int soglia = 65;
int cont = 0;
int azzera = 200;
bool stato = 0;


void setup() {
  pinMode(mic,INPUT); //in del microfono
  Serial.begin(9600);

}

void loop() {

  if(analogRead(mic)>soglia){
    cont++;
    delay(del);
  }
  
  if(azzera == 0){
    azzera = 100;
    cont = 0;
  }

  if(cont == 2 ){
    azzera = 100;
    stato = !stato;
    cont = 0;
  }

  if(stato = 0)
  {
  Serial.print("p"); //spegne 
  }
  if(stato = 1)
  {
    Serial.print("P"); //accende
  }
  
  }
azzera--;

}
