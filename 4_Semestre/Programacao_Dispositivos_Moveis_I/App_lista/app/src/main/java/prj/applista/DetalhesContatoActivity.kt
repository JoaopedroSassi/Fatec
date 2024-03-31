package prj.applista

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.EditText
import androidx.core.text.set
import prj.applista.models.Contato

class DetalhesContatoActivity : AppCompatActivity() {
    var contato:Contato?=null
    var txtNome:EditText?=null
    var txtEmail:EditText?=null
    var txtTelefone:EditText?=null
    var txtEndereco:EditText?=null


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_detalhes_contato)

        txtNome = findViewById(R.id.txtNome)
        txtEmail = findViewById(R.id.txtEmail)
        txtTelefone = findViewById(R.id.txtTelefone)
        txtEndereco = findViewById(R.id.txtEndereco)

        if (this.intent.hasExtra("contato")) {
            contato = this.intent.getSerializableExtra("contato") as Contato?
            preencherContato()
        }
    }

    private fun preencherContato() {
        txtNome?.setText(contato?.nome)
        txtEmail?.setText(contato?.email)
        txtTelefone?.setText(contato?.telefone)
        txtEndereco?.setText(contato?.endereco)
    }
}