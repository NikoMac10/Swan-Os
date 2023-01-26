Swan Os is a small project, with an operating system very similar in functioning, to the internal computer of the Lost Swan station.
This operating system was created using the ReactOS framework https://reactos.org/
The purpose of this project is to try to make something more similar and surprising than the innumerable programs that simulate the functioning of the swan station computer.
I don't want to take away the credit from these programs, but the idea of an operating system that performs this task seems to me much more scenic and realistic than a program written for windows.

The huge difference from the tv series computer is that the timer is incorporated inside the computer, while as you will remember from the TV series, the timer was physical and hung on the wall.
Other small differences are:
1) The loading screen that anticipates the timer screen has not been shown in the TV series, however i wanted to add it because it is very scenic and pretty.
2) Beep sound, unfortunately due to some software limitations they are not exactly the same and in some computers they cannot be heard.

For the rest everything you see and hear is quite faithful to how it happened in the computer of the swan station, the numbers can only be entered when there are less than 4 minutes left, when there are less than 4 minutes left a beep is heard every 2 seconds, when there less than 1 minute a more aggressive beep is heard every 2 seconds, when there are less than 10 seconds left until the sequence is entered a very aggressive beep is heard every second.

When the timer expires the red hieroglyphs will appear on the timer (what you see was the best i could do with a console that only shows CP437 characters) and the wording "System Failure" will repeatedly appear on the screen, from now on if not the lost numbers will be typed in the console within a few seconds, the computer will turn off.

The chat with Walt has also been fully implemented which will be activated by pressing the "ESC" button on the keyboard, located in the upper left corner.
In the chat we obviously play Michael, so we should write what Michael really wrote in the TV series to progress with the conversation. The sentences we will write may have different punctuation and/or lowercase/uppercase characters different from the original, it doesn't matter, they will work the same.

HOW TO TRY IT ON A COMPUTER?
1) Download the zipped iso.
2) Extract and burn the iso image with the Rufus program on a usb stick.
3) Check the following rufus settings: partition scheme (MBR), target system (Bios(or UEFI CSM)).
4) Turn on the target computer and enter the bios and set the boot mode to (BIOS/Legacy).
5) If necessary change the boot order of the devices, and put the stick as the first boot device.
6) Enjoy the countdown ;)

If you want you can also test the iso with VMWare or virtualbox, just create the virtual machine and select the iso as boot device.

HOW TO IMPORT THE PROJECT/SOURCE CODE?
1) Do all the listed prerequisites : https://reactos.org/wiki/Building_ReactOS
2) Create a new Cosmos Kernel on Visual Studio project
3) Import the source code of Swan Os (copy and paste)
4) Download and Install VMWare for debugging.
