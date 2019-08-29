@echo off
color 02
echo.
echo Welcome to my amazing game!
echo Are you ready to start?
choice /c:yn
if errorlevel 2 goto abandon
if errorlevel 1 goto start
:start
echo Alright then! Let us embark on this adventure!
:begin
echo You wake up in the morning, laying in bed. Next to you is your
echo trusted sword and a pint of water. You immediately take your
echo sword, as by instinct. What do you want to do now?
echo [G]et out of bed or [D]rink the water?
choice /c:gd
if errorlevel 2 goto drink_water_bed
if errorlevel 1 goto out_of_bed
:drink_water_bed
echo You spill most of the water unto the bed, and are now soaked wet.
echo Do you want to get out of bed now?
choice /c:yn
if errorlevel 2 goto asleep
if errorlevel 1 goto out_of_bed_wet
:asleep
echo You fall asleep once again
goto begin
:out_of_bed_wet
echo You should probably change clothes first. Do you wish to do so?
choice /c:yn
if errorlevel 2 goto wet_clothes
if errorlevel 1 goto change_clothes
:wet_clothes
echo Seeing your dry clothes next to you while you have wet clothes
echo makes you change clothes anyway.
goto change_clothes
goto gameover
:change_clothes
echo You change into a new set of clothes, and let the old
echo one let to dry.
goto out_of_bed
:out_of_bed
echo You take a look around the room, and find out you are in a dusty
echo old shack, a place where you've never been before. In front of you
echo you see a door. Apart from some hanging clothes, the pint of water
echo and the bed, nothing else is present.
echo Do you want to [D]rink the water, [P]ack your clothes or [H]ead
echo straight out the front door?
choice /c:dph
if errorlevel 3 goto outside_shack
if errorlevel 2 goto packed_clothes
if errorlevel 1 goto drank_water
:drank_water
echo Some water was left in the pint. You drink it all.
echo What do you want to do now? [P]ack your clothes or [H]ead outside?
choice /c:ph
if errorlevel 2 goto outside_shack
if errorlevel 1 goto packed_clothes_emptywater
:packed_clothes
echo You realise your clothes are all wet, and decide not to bring them
echo Do you want to [d]rink the water or [h]ead outside?
choice /c:dh
if errorlevel 2 goto outside_shack
if errorlevel 1 goto drank_water_clothes
:packed_clothes_emptywater
echo You realise your clothes are all wet, and decide not to bring them
echo The only thing left for you is to go outside, so you head to the
echo door.
goto outside_shack
:drank_water_clothes
echo Some water was left in the pint. You drink it all.
echo The only thing left for you is to go outside, so you head to the
echo door.
goto outside_shack
:outside_shack
echo You find yourself in a forest, facing north. In front of you is a
echo path that seems to go forward for as far as you can see. Do you
echo want to go [N]orth, or check what is [B]ehind the shack?
choice /c:nb
if errorlevel 2 goto behind_shack
if errorlevel 1 goto northofshack
:behind_shack
echo As you arrive on the outside south wall of the shack, you find a
echo dead body. Do you want to [E]xamine the body, head [S]outh or go
echo back [N]orth?
choice /C:ESN
if errorlevel 3 goto outside_shack
if errorlevel 2 goto arrowshot_southshack
if errorlevel 1 goto examine_bodyshack
:arrowshot_southshack
echo As you head south, you hear something moving on your left. Before
echo you had time to react, you get shot by an arrow in the neck. You
echo can see your blood dripping and falling to the ground as you die.
goto gameover
:examine_bodyshack
echo After examining the body, you see that the person died of an arrow
echo in the jugular. Also, you see that some tracks have been made, as
echo if the body was dragged from the south.
echo Do you want to head [S]outh to investigate the murder or go back
echo [N]orth?
choice /C:SN
if errorlevel 2 goto outside_shack
if errorlevel 1 goto arrowshot_southshack
:northofshack
echo You are walking along the road when you are attacked by a gang of
echo three goblins, wielding clubs. Do you want to get into a [D]efense
echo position, [C]harge, sword in hand, through them, or [R]un back to
echo the shack?
choice /C:DCR
if errorlevel 3 goto outside_shack
if errorlevel 2 goto charge_goblins1
if errorlevel 1 goto defense_goblins1
:charge_goblins1
echo Using your acute ability with your sword, you are able to kill two
echo of the goblins. The other, seeing what you have done, flees to the
echo west. Do you want to [P]ursue him or to continue to head [N]orth?
choice /C:PN
if errorlevel 2 goto northpath_pastgoblins
if errorlevel 1 goto west_goblins
:defense_goblins1
echo You get your sword ready, but the three goblins attack you all at
echo once and too fast for you to react. You soon receive a hard blow
echo to the head, and lose consciousness, never to regain it again.
goto gameover
:west_goblins
echo You run after the last goblin, fueled by rage. The goblin's speed
echo makes it hard for you to follow him, but you still are able to get
echo it to stop. However, you see that it stares back at you, with a grin
echo on its face. You suddenly hear several goblins shout from the trees
echo as you see a wall of arrows coming at you.
goto gameover
:northpath_pastgoblins
echo This part is underconstruction. That is why I will have to send you
echo to the gameover screen.
goto gameover
goto end
:abandon
echo Alright then, have a nice day!
goto end
:gameover
echo Sorry! You died!
pause
echo Do you want to try again?
choice /c:YN
if errorlevel 2 goto end
if errorlevel 1 goto start
:end
echo Thank you for playing!
echo Alexandre Moreau (c) 2012
pause