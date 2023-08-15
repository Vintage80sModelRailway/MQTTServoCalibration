# MQTTServoCalibration

A very simple tool to calibrate servos while they're being managed on a 'live' layout.

Edit the app.config / MQTTMessenger.config file to set your own defaults.

There is no checking for values that could damage servos so use carefully.

It doesn't actually 'throw' or 'close' a turnout (in JMRI states) it just moves the servo, so best to move the servo back to the state that JMRI thinks it's in when you're done.

See here, line 163 for some example code on receiving and processing the messages that this app sends on an Arduino / ESP32.

https://github.com/Vintage80sModelRailway/JMRI-MQTT-ESP32-ServoControl/blob/main/MQTT_Client_ESP_Corner3_degrees/MQTT_Client_ESP_Corner3_degrees.ino
