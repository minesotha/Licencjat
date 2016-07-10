Wszystkie skrypty zawarte w folderze assets/scripts.

Dla skryptów ruchu : assets/scripts/Object Manipulation.
Zalecane wykorzystanie skryptu VelocityDrag(obecnie niepodpiêty pod ¿aden obiekt na scenie). Konieczne jest dopisanie jedynie zmiany koordynatów lokalnych w zaleznosci od rotacji kamery. Jest tam równie¿ rotate, który obrac obiekt o 45 stopni po nacisnieciu "[" i "]" jesli kursor u¿ytkownika sie na nim znajduje. Dodatkowo obiekt musi miec tag "rotateable".

W folderze assets/scripts/CameraControl skrypt do obs³ugi kamery (podczepiamy pod main kamere). Znajduj¹ siê tam równie¿ skrypty do obs³ugi przejœcia w fullscreen oraz zmiany kamery na inn¹ (tworzymy obiekt nadrzêdny, podpinamy pod niego obie kamery i skrypt, a w nim podczepiamy obydwie kamery jako Camera i Camera2).

Zaimportowano pare darmowych assetow z UnityStore, oraz dwa obiekty z Voxbox'owych mebli(trzeba osobno oteksturowaæ).

Dla obs³ugi screenshotow: assets/scripts/ SnapshotControl i SnapshotSave. Znajduje siê tam równierz skrypt do instancjowania obiektów na œrodku sceny (poki co wgrywa krzeslo z resourceow, ale nic nie szkodzi na przeszkodzie, zeby u¿yæ tam prefaba z do³aczonymi skryptami)

W kwesti UI - jest wytworzony prosty canvas + kilka buttonow do testów, ale z jakiegoœ powodu po u¿yciu skryptu na chwytanie obiektów buttony przestaja reagowaæ na input.