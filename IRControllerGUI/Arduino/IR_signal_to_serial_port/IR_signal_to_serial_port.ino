#include <IRremote.h>

const int irReceiverPin = 7;
IRrecv irrecv(irReceiverPin);
decode_results results;

//code values by row
const long power_btn_code = 16753245;
const long capture_btn_code = 16736925;
const long mute_btn_code = 16769565;

const long play_btn_code = 16720605;
const long prev_btn_code = 16712445;
const long next_btn_code = 16761405;

const long eq_btn_code = 16769055;
const long vol_down_btn_code = 16754775;
const long vol_up_btn_code = 16748655;

const long game_btn_code = 16750695;
const long usb_scan_btn_code = 16756815;
const long zero_btn_code = 16738455;

const long one_btn_code = 16724175;
const long two_btn_code = 16718055;
const long three_btn_code = 16743045;

const long four_btn_code = 16716015;
const long five_btn_code = 16726215;
const long six_btn_code = 16734885;

const long seven_btn_code = 16728765;
const long eight_btn_code = 16730805;
const long nine_btn_code = 16732845;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  irrecv.enableIRIn();
}

void map_ir_code(long code) {
  switch (code) {
    case power_btn_code:
      Serial.println("IRPowerButton");
      break;

    case capture_btn_code: 
      Serial.println("IRCaptureButton");
      break;

    case mute_btn_code:
      Serial.println("IRMuteButton");
      break;

    case play_btn_code:
      Serial.println("IRPlayButton");
      break;

    case prev_btn_code:
      Serial.println("IRPrevButton");
      break;

    case next_btn_code:
      Serial.println("IRNextButton");
      break;

    case eq_btn_code:
      Serial.println("IREQButton");
      break;

    case vol_down_btn_code:
      Serial.println("IRVolDownButton");
      break;

    case vol_up_btn_code:
      Serial.println("IRVolUpButton");
      break;

    case zero_btn_code:
      Serial.println("Button_0");
      break;
    
    case game_btn_code:
      Serial.println("IRGameButton");
      break;

    case usb_scan_btn_code:
      Serial.println("IRUSBScanButton");
      break;

    case one_btn_code:
      Serial.println("Button_1");
      break;

    case two_btn_code:
      Serial.println("Button_2");
      break;

    case three_btn_code:
      Serial.println("Button_3");
      break;

    case four_btn_code:
      Serial.println("Button_4");
      break;

    case five_btn_code:
      Serial.println("Button_5");
      break;

    case six_btn_code:
      Serial.println("Button_6");
      break;

    case seven_btn_code:
      Serial.println("Button_7");
      break;

    case eight_btn_code:
      Serial.println("Button_8");
      break;

    case nine_btn_code:
      Serial.println("Button_9");
      break;

    default:
      break;  // ignore unknown codes
  }
}

void loop() {
  if (irrecv.decode(&results))  // results mem address
  {
    map_ir_code(results.value);
    irrecv.resume();  // receive the next value
  }
  delay(600);
}
