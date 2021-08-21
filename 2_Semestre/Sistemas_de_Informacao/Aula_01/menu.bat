@echo off
title Aula 01 - Programacao Batch
:inicio
cls
echo.
echo          (o   o)
echo ======ooO==( )==Ooo========
echo         Menu Principal
echo ===========================
echo [W] Executar o Word
echo [E] Executar o Excel
echo [C] Calculadora
echo [P] Paint
echo [V] Verificar Versao Windows
echo [N] Navergar Web
echo [T] Teste de Conexao de Rede
echo [F] Finalizar o Programa
echo ============================
echo.
set /p op=Digite sua opcao :
if /i %op% equ w (goto:word)
if /i %op% equ e (goto:excel)
if /i %op% equ c (goto:calculadora)
if /i %op% equ p (goto:arte_desenho)
if /i %op% equ v (goto:versao_win)
if /i %op% equ n (goto:web)
if /i %op% equ t (goto:teste)
if /i %op% equ f (goto:sair) else (
   echo.
   echo -------------------
   echo  Opcao Invalida!
   echo -------------------
   pause > nul
   goto:inicio )

:word
start winword.exe
goto:inicio

:excel
start excel.exe
goto:inicio

:calculadora
start calc.exe
goto:inicio

:arte_desenho
start mspaint.exe
goto:inicio

:versao_win
start winver.exe
goto:inicio

:web
echo.
set /p site=Digite o endereco da pagina web:
start %site%
goto:inicio

:teste
echo.
set /p conexao=Digite o IP ou endereco da pagina:
ping %conexao% -t

:sair
echo.
set /p resp=Deseja realmente encerrar? [S/N]:
if /i %resp% == s (exit) else (goto:inicio)