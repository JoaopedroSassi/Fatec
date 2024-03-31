package prj.applista.dao

import prj.applista.models.Contato

class DaoContatos {
    fun ListaContatos():ArrayList<Contato>{
        val list:ArrayList<Contato> = ArrayList()
        list.add(Contato("Usuário 1", "usuario@bigode.com.br","123456789","Av. Antônia Rosa Fioravanti, 804, Mauá","#"))
        list.add(Contato("Usuário 2", "japones@bigode.com.br","987654321","Av. Antônia Rosa Fioravanti, 804, Mauá","#"))
        list.add(Contato("Usuário 3", "solteiro@forcado.com.br","123456789","Av. Antônia Rosa Fioravanti, 804, Mauá","#"))
        list.add(Contato("Usuário 45", "Luketa@bigamo.com.br","00000125","Av. Antônia Rosa Fioravanti, 804, Mauá","#"))

        return list
    }
}