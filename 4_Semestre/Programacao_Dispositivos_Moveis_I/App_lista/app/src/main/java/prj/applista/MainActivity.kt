package prj.applista

import android.content.Intent
import android.net.Uri
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.MenuItem
import androidx.core.view.get
import androidx.recyclerview.widget.RecyclerView
import prj.applista.adapters.ListaContatoAdapter
import prj.applista.dao.DaoContatos
import prj.applista.models.Contato

class MainActivity : AppCompatActivity() {
    lateinit var  listContatos:RecyclerView

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        listContatos = findViewById(R.id.listContatos)
        val dao = DaoContatos()
        listContatos.adapter = ListaContatoAdapter(dao.ListaContatos())
    }

    override fun onContextItemSelected(item: MenuItem): Boolean {
        val dao = DaoContatos()

        val adapter: ListaContatoAdapter = listContatos.adapter as ListaContatoAdapter
        val posicao: Int = adapter.posicaoClicada
        val contato: Contato = dao.ListaContatos().get(posicao)

        if (item.itemId == R.id.menu_mapa) {
            val uri:Uri = Uri.parse("geo:0, 0?q=" + contato.endereco+"&z=18")
            val intent:Intent = Intent(Intent.ACTION_VIEW, uri)
            startActivity(intent)
        } else if (item.itemId == R.id.menu_ligacao) {
            val uri:Uri = Uri.parse("tel:" + contato.telefone)
            val intent:Intent = Intent(Intent.ACTION_VIEW, uri)
            startActivity(intent)
        } else if (item.itemId == R.id.menu_email) {
            val uri:Uri = Uri.parse("mailto:" + contato.email)
            val intent:Intent = Intent(Intent.ACTION_VIEW, uri)
            startActivity(intent)
        } else if (item.itemId == R.id.menu_detalhes) {
            val intent:Intent = Intent(this, DetalhesContatoActivity::class.java)
            intent.putExtra("contato", contato)
            startActivity(intent)
        }

        return super.onContextItemSelected(item)
    }
}