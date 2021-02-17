#define SW1 48

//int i = 0;
uint8_t buff [] = {0x20, 0x20, 0x32, 0x30, 0x2E, 0x33, 0x38, 0x35, 0x20, 0x20, 0x20, 0x6b, 0x67,0x20, 0x0D, 0x0A};
//uint32_t buff2[4] = {0x20203220, 0x2E333835, 2020206b, 67200d0a}
void setup() {
  

  Serial.begin(4800);
  pinMode(SW1, INPUT_PULLUP);
  
// [  20.385   kg 
// ] <--- ENTER
// 20 20 32 30     2e 33 38 35    20 20 20 6b     67 20 0d 0a
}

void loop() {


  if(buff[2] == 0x32){
    buff[2] = 0x30;
  }
  else buff[2]=0x32;

  if(buff[3] == 0x30){
    buff[3] = 0x32;
  }
  else buff[3]=0x30;

  if(buff[5] == 0x33){
    buff[3] = 0x38;
  }
  else buff[3]=0x33;

  if(buff[6] == 0x35){
    buff[6] = 0x38;
  }
  else buff[6]=0x35;
  
  
  while(digitalRead(SW1) == LOW){
    Serial.write(buff,16);
    delay(1000);
  }


}
