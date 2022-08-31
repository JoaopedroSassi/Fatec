@echo off
title Aula 02 - Atividade Randomicos
mode 60,30
color 0a
set /a numero=((%random% %%50) + 1)
set /a cont = 5
		
:ini
cls								          
echo ==========================================       
echo      SORTEIO SORTEIO SORTEIO 1-50
echo ------------------------------------------         
echo Numero de tentativas atual: %cont%
echo ==========================================         
if %cont% == 0 (goto:perdeu) else echo.
set /p palp=Digite seu palpite:
if /i %palp% == %numero% (goto:ganhou) else (goto:errou)


:ganhou
echo Voce acertou! O numero era: %numero%
set /p jogar=Deseja jogar novamente? [S/N]
if /i %jogar% == s (goto:sort) else (exit)

:errou
if %cont% Leq 0 (goto:perdeu) else (goto:verifica)

:perdeu
echo Voce perdeu! O numero era %numero%
set /p jogar=Deseja jogar novamente? [S/N]
if /i %jogar% == s (goto:sort) else (exit)

:sort
set /a numero=((%random% %%50) + 1)
set /a cont = 5
goto:ini

:verifica
set /a cont = %cont% - 1
if %palp% GTR %numero% (goto:maior) else (goto:menor)
	
:maior
echo Digite um numero menor!
pause > nul
goto:ini

:menor
echo Digite um numero maior!
pause > nul
goto:ini
