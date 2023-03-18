package com.mycompany.ex03;

import java.time.LocalDate;

public class Ex03 {
    public static void main(String[] args) {
        int diaAtual = LocalDate.now().getDayOfMonth();
        int mesAtual = LocalDate.now().getMonthValue();
        int anoAtual = LocalDate.now().getYear();

        Pessoa albertEinstein = new Pessoa("Albert Einstein");
        albertEinstein.ajustaDataNascimento(14, 03, 1879);
        albertEinstein.calculaIdade(diaAtual, mesAtual, anoAtual);

        Pessoa isacNewton = new Pessoa("Isac Newton");
        isacNewton.ajustaDataNascimento(04, 01, 1643);
        isacNewton.calculaIdade(diaAtual, mesAtual, anoAtual);

        System.out.println(albertEinstein.informaNome() + " teria " + albertEinstein.informaIdade() + " anos");
        System.out.println(isacNewton.informaNome() + " teria " + isacNewton.informaIdade() + " anos");
    }
}
