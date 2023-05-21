public class Ex01 extends javax.swing.JFrame {
    
    private double v1;
    private double v2;
    private String op;

    public Ex01() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton13 = new javax.swing.JButton();
        jButton14 = new javax.swing.JButton();
        jButton15 = new javax.swing.JButton();
        jButton16 = new javax.swing.JButton();
        lbl7 = new javax.swing.JButton();
        lblResult = new javax.swing.JTextField();
        lbl9 = new javax.swing.JButton();
        lbl8 = new javax.swing.JButton();
        lblDiv = new javax.swing.JButton();
        lbl4 = new javax.swing.JButton();
        lbl6 = new javax.swing.JButton();
        lbl5 = new javax.swing.JButton();
        lblMulti = new javax.swing.JButton();
        lbl1 = new javax.swing.JButton();
        lbl3 = new javax.swing.JButton();
        lbl2 = new javax.swing.JButton();
        lblMenos = new javax.swing.JButton();
        lbl0 = new javax.swing.JButton();
        lblIgual = new javax.swing.JButton();
        lblPonto = new javax.swing.JButton();
        lblSoma = new javax.swing.JButton();

        jButton13.setText("jButton1");

        jButton14.setText("jButton1");

        jButton15.setText("jButton1");

        jButton16.setText("jButton1");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        lbl7.setText("7");
        lbl7.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lbl7ActionPerformed(evt);
            }
        });

        lblResult.setName(""); // NOI18N

        lbl9.setText("9");
        lbl9.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lbl9ActionPerformed(evt);
            }
        });

        lbl8.setText("8");
        lbl8.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lbl8ActionPerformed(evt);
            }
        });

        lblDiv.setText("/");
        lblDiv.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lblDivActionPerformed(evt);
            }
        });

        lbl4.setText("4");
        lbl4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lbl4ActionPerformed(evt);
            }
        });

        lbl6.setText("6");
        lbl6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lbl6ActionPerformed(evt);
            }
        });

        lbl5.setText("5");
        lbl5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lbl5ActionPerformed(evt);
            }
        });

        lblMulti.setText("*");
        lblMulti.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lblMultiActionPerformed(evt);
            }
        });

        lbl1.setText("1");
        lbl1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lbl1ActionPerformed(evt);
            }
        });

        lbl3.setText("3");
        lbl3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lbl3ActionPerformed(evt);
            }
        });

        lbl2.setText("2");
        lbl2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lbl2ActionPerformed(evt);
            }
        });

        lblMenos.setText("-");
        lblMenos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lblMenosActionPerformed(evt);
            }
        });

        lbl0.setText("0");
        lbl0.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lbl0ActionPerformed(evt);
            }
        });

        lblIgual.setText("=");
        lblIgual.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lblIgualActionPerformed(evt);
            }
        });

        lblPonto.setText(".");
        lblPonto.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lblPontoActionPerformed(evt);
            }
        });

        lblSoma.setText("+");
        lblSoma.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lblSomaActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblResult)
                .addContainerGap())
            .addGroup(layout.createSequentialGroup()
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(lbl0, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(lblPonto, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(lblIgual, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(lblSoma, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                        .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                            .addComponent(lbl1, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(lbl2, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(lbl3, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(lblMenos, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGroup(layout.createSequentialGroup()
                            .addComponent(lbl4, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(lbl5, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(lbl6, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(lblMulti, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGroup(layout.createSequentialGroup()
                            .addComponent(lbl7, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(lbl8, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(lbl9, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(lblDiv, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addContainerGap(20, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblResult, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lbl7, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl9, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl8, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblDiv, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lbl4, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl6, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl5, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblMulti, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lbl1, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl3, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl2, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblMenos, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lbl0, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblIgual, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblPonto, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblSoma, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(24, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void lbl7ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lbl7ActionPerformed
        lblResult.setText(lblResult.getText() + lbl7.getText());
    }//GEN-LAST:event_lbl7ActionPerformed

    private void lbl8ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lbl8ActionPerformed
        lblResult.setText(lblResult.getText() + lbl8.getText());
    }//GEN-LAST:event_lbl8ActionPerformed

    private void lblSomaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lblSomaActionPerformed
        v1 = Double.parseDouble(lblResult.getText());
        lblResult.setText("");
        op = "Soma";
    }//GEN-LAST:event_lblSomaActionPerformed

    private void lblIgualActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lblIgualActionPerformed
        v2 = Double.parseDouble(lblResult.getText());
        
        if (op == "Soma"){
            lblResult.setText(Double.toString(v1 + v2));
        } else if (op == "Subt") {
            lblResult.setText(Double.toString(v1 - v2));
        } else if (op == "Mult") {
            lblResult.setText(Double.toString(v1 * v2));
        } else if (op == "Div") {
            lblResult.setText(Double.toString(v1 / v2));
        }
    }//GEN-LAST:event_lblIgualActionPerformed

    private void lbl9ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lbl9ActionPerformed
        lblResult.setText(lblResult.getText() + lbl9.getText());
    }//GEN-LAST:event_lbl9ActionPerformed

    private void lbl4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lbl4ActionPerformed
        lblResult.setText(lblResult.getText() + lbl4.getText());
    }//GEN-LAST:event_lbl4ActionPerformed

    private void lbl5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lbl5ActionPerformed
        lblResult.setText(lblResult.getText() + lbl5.getText());
    }//GEN-LAST:event_lbl5ActionPerformed

    private void lbl6ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lbl6ActionPerformed
        lblResult.setText(lblResult.getText() + lbl6.getText());
    }//GEN-LAST:event_lbl6ActionPerformed

    private void lbl1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lbl1ActionPerformed
        lblResult.setText(lblResult.getText() + lbl1.getText());
    }//GEN-LAST:event_lbl1ActionPerformed

    private void lbl2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lbl2ActionPerformed
        lblResult.setText(lblResult.getText() + lbl2.getText());
    }//GEN-LAST:event_lbl2ActionPerformed

    private void lbl3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lbl3ActionPerformed
        lblResult.setText(lblResult.getText() + lbl3.getText());
    }//GEN-LAST:event_lbl3ActionPerformed

    private void lbl0ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lbl0ActionPerformed
        lblResult.setText(lblResult.getText() + lbl0.getText());
    }//GEN-LAST:event_lbl0ActionPerformed

    private void lblMenosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lblMenosActionPerformed
        v1 = Double.parseDouble(lblResult.getText());
        lblResult.setText("");
        op = "Subt";
    }//GEN-LAST:event_lblMenosActionPerformed

    private void lblMultiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lblMultiActionPerformed
        v1 = Double.parseDouble(lblResult.getText());
        lblResult.setText("");
        op = "Mult";
    }//GEN-LAST:event_lblMultiActionPerformed

    private void lblDivActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lblDivActionPerformed
        v1 = Double.parseDouble(lblResult.getText());
        lblResult.setText("");
        op = "Div";
    }//GEN-LAST:event_lblDivActionPerformed

    private void lblPontoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_lblPontoActionPerformed
        lblResult.setText(lblResult.getText() + lblPonto.getText());
    }//GEN-LAST:event_lblPontoActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Ex01.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Ex01.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Ex01.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Ex01.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Ex01().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton13;
    private javax.swing.JButton jButton14;
    private javax.swing.JButton jButton15;
    private javax.swing.JButton jButton16;
    private javax.swing.JButton lbl0;
    private javax.swing.JButton lbl1;
    private javax.swing.JButton lbl2;
    private javax.swing.JButton lbl3;
    private javax.swing.JButton lbl4;
    private javax.swing.JButton lbl5;
    private javax.swing.JButton lbl6;
    private javax.swing.JButton lbl7;
    private javax.swing.JButton lbl8;
    private javax.swing.JButton lbl9;
    private javax.swing.JButton lblDiv;
    private javax.swing.JButton lblIgual;
    private javax.swing.JButton lblMenos;
    private javax.swing.JButton lblMulti;
    private javax.swing.JButton lblPonto;
    private javax.swing.JTextField lblResult;
    private javax.swing.JButton lblSoma;
    // End of variables declaration//GEN-END:variables
}
