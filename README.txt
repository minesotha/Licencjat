Wszystkie skrypty zawarte w folderze assets/scripts.

Dla skrypt�w ruchu : assets/scripts/Object Manipulation.
Zalecane wykorzystanie skryptu VelocityDrag(obecnie niepodpi�ty pod �aden obiekt na scenie). Konieczne jest dopisanie jedynie zmiany koordynat�w lokalnych w zaleznosci od rotacji kamery. Jest tam r�wnie� rotate, kt�ry obrac obiekt o 45 stopni po nacisnieciu "[" i "]" jesli kursor u�ytkownika sie na nim znajduje. Dodatkowo obiekt musi miec tag "rotateable".

W folderze assets/scripts/CameraControl skrypt do obs�ugi kamery (podczepiamy pod main kamere). Znajduj� si� tam r�wnie� skrypty do obs�ugi przej�cia w fullscreen oraz zmiany kamery na inn� (tworzymy obiekt nadrz�dny, podpinamy pod niego obie kamery i skrypt, a w nim podczepiamy obydwie kamery jako Camera i Camera2).

Zaimportowano pare darmowych assetow z UnityStore, oraz dwa obiekty z Voxbox'owych mebli(trzeba osobno oteksturowa�).

Dla obs�ugi screenshotow: assets/scripts/ SnapshotControl i SnapshotSave. Znajduje si� tam r�wnierz skrypt do instancjowania obiekt�w na �rodku sceny (poki co wgrywa krzeslo z resourceow, ale nic nie szkodzi na przeszkodzie, zeby u�y� tam prefaba z do�aczonymi skryptami)

W kwesti UI - jest wytworzony prosty canvas + kilka buttonow do test�w, ale z jakiego� powodu po u�yciu skryptu na chwytanie obiekt�w buttony przestaja reagowa� na input.