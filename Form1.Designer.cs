namespace SiroomB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelRuangan = new Label();
            labelSelamatDatang = new Label();
            pictureBoxQRCode = new PictureBox();
            labelQRCode = new Label();
            labelDetailQRCode = new Label();
            labelRekap = new Label();
            pictureBoxProfil = new PictureBox();
            pictureBoxKalender = new PictureBox();
            pictureBoxPoint = new PictureBox();
            labelDosen = new Label();
            labelKelas = new Label();
            labelTime = new Label();
            labelTanggal = new Label();
            labelPMatkul = new Label();
            labelMatkul = new Label();
            panelTepatWaktu = new Panel();
            labelTepatWaktu = new Label();
            progressBarTepatWaktu = new ProgressBar();
            panelTerlambat = new Panel();
            labelTerlambat = new Label();
            progressBarTerlambat = new ProgressBar();
            panelTidakMasuk = new Panel();
            progressBarTIdakMasuk = new ProgressBar();
            labelTidakMasuk = new Label();
            dataGridViewRekap = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKalender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoint).BeginInit();
            panelTepatWaktu.SuspendLayout();
            panelTerlambat.SuspendLayout();
            panelTidakMasuk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRekap).BeginInit();
            SuspendLayout();
            // 
            // labelRuangan
            // 
            labelRuangan.AutoSize = true;
            labelRuangan.Location = new Point(51, 32);
            labelRuangan.Name = "labelRuangan";
            labelRuangan.Size = new Size(226, 48);
            labelRuangan.TabIndex = 0;
            labelRuangan.Text = "Ruangan 333";
            // 
            // labelSelamatDatang
            // 
            labelSelamatDatang.AutoSize = true;
            labelSelamatDatang.Location = new Point(65, 125);
            labelSelamatDatang.Name = "labelSelamatDatang";
            labelSelamatDatang.Size = new Size(270, 48);
            labelSelamatDatang.TabIndex = 1;
            labelSelamatDatang.Text = "Selamat Datang";
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Location = new Point(84, 378);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(680, 389);
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQRCode.TabIndex = 2;
            pictureBoxQRCode.TabStop = false;
            // 
            // labelQRCode
            // 
            labelQRCode.AutoSize = true;
            labelQRCode.Location = new Point(73, 213);
            labelQRCode.Name = "labelQRCode";
            labelQRCode.Size = new Size(162, 48);
            labelQRCode.TabIndex = 3;
            labelQRCode.Text = "QR Code";
            // 
            // labelDetailQRCode
            // 
            labelDetailQRCode.AutoSize = true;
            labelDetailQRCode.Location = new Point(71, 280);
            labelDetailQRCode.Name = "labelDetailQRCode";
            labelDetailQRCode.Size = new Size(716, 48);
            labelDetailQRCode.TabIndex = 4;
            labelDetailQRCode.Text = "Scan QR Code ini untuk melakukan presensi";
            // 
            // labelRekap
            // 
            labelRekap.AutoSize = true;
            labelRekap.Location = new Point(113, 851);
            labelRekap.Name = "labelRekap";
            labelRekap.Size = new Size(117, 48);
            labelRekap.TabIndex = 5;
            labelRekap.Text = "Rekap";
            // 
            // pictureBoxProfil
            // 
            pictureBoxProfil.Image = Properties.Resources.profil;
            pictureBoxProfil.Location = new Point(1159, 342);
            pictureBoxProfil.Name = "pictureBoxProfil";
            pictureBoxProfil.Size = new Size(144, 124);
            pictureBoxProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfil.TabIndex = 7;
            pictureBoxProfil.TabStop = false;
            // 
            // pictureBoxKalender
            // 
            pictureBoxKalender.Image = Properties.Resources.kalender;
            pictureBoxKalender.Location = new Point(1171, 502);
            pictureBoxKalender.Name = "pictureBoxKalender";
            pictureBoxKalender.Size = new Size(123, 141);
            pictureBoxKalender.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxKalender.TabIndex = 8;
            pictureBoxKalender.TabStop = false;
            // 
            // pictureBoxPoint
            // 
            pictureBoxPoint.Image = Properties.Resources.point;
            pictureBoxPoint.Location = new Point(1143, 673);
            pictureBoxPoint.Name = "pictureBoxPoint";
            pictureBoxPoint.Size = new Size(182, 123);
            pictureBoxPoint.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPoint.TabIndex = 9;
            pictureBoxPoint.TabStop = false;
            // 
            // labelDosen
            // 
            labelDosen.AutoSize = true;
            labelDosen.Location = new Point(1379, 324);
            labelDosen.Name = "labelDosen";
            labelDosen.Size = new Size(224, 48);
            labelDosen.TabIndex = 10;
            labelDosen.Text = "Nama Dosen";
            // 
            // labelKelas
            // 
            labelKelas.AutoSize = true;
            labelKelas.Location = new Point(1372, 405);
            labelKelas.Name = "labelKelas";
            labelKelas.Size = new Size(102, 48);
            labelKelas.TabIndex = 11;
            labelKelas.Text = "Kelas";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(1381, 603);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(231, 48);
            labelTime.TabIndex = 13;
            labelTime.Text = "Waktu, Menit";
            // 
            // labelTanggal
            // 
            labelTanggal.AutoSize = true;
            labelTanggal.Location = new Point(1388, 522);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new Size(226, 48);
            labelTanggal.TabIndex = 12;
            labelTanggal.Text = "Hari, Tanggal";
            // 
            // labelPMatkul
            // 
            labelPMatkul.AutoSize = true;
            labelPMatkul.Location = new Point(1381, 771);
            labelPMatkul.Name = "labelPMatkul";
            labelPMatkul.Size = new Size(252, 48);
            labelPMatkul.TabIndex = 15;
            labelPMatkul.Text = "Pertemuan ke-";
            // 
            // labelMatkul
            // 
            labelMatkul.AutoSize = true;
            labelMatkul.Location = new Point(1388, 690);
            labelMatkul.Name = "labelMatkul";
            labelMatkul.Size = new Size(207, 48);
            labelMatkul.TabIndex = 14;
            labelMatkul.Text = "Mata Kuliah";
            // 
            // panelTepatWaktu
            // 
            panelTepatWaktu.BackColor = Color.LimeGreen;
            panelTepatWaktu.Controls.Add(labelTepatWaktu);
            panelTepatWaktu.Controls.Add(progressBarTepatWaktu);
            panelTepatWaktu.Location = new Point(84, 951);
            panelTepatWaktu.Name = "panelTepatWaktu";
            panelTepatWaktu.Size = new Size(582, 292);
            panelTepatWaktu.TabIndex = 16;
            // 
            // labelTepatWaktu
            // 
            labelTepatWaktu.AutoSize = true;
            labelTepatWaktu.ForeColor = Color.White;
            labelTepatWaktu.Location = new Point(56, 59);
            labelTepatWaktu.Name = "labelTepatWaktu";
            labelTepatWaktu.Size = new Size(216, 48);
            labelTepatWaktu.TabIndex = 3;
            labelTepatWaktu.Text = "Tepat Waktu";
            // 
            // progressBarTepatWaktu
            // 
            progressBarTepatWaktu.BackColor = Color.LimeGreen;
            progressBarTepatWaktu.ForeColor = Color.Transparent;
            progressBarTepatWaktu.Location = new Point(56, 164);
            progressBarTepatWaktu.Name = "progressBarTepatWaktu";
            progressBarTepatWaktu.Size = new Size(479, 69);
            progressBarTepatWaktu.TabIndex = 3;
            progressBarTepatWaktu.Value = 20;
            // 
            // panelTerlambat
            // 
            panelTerlambat.BackColor = Color.Gold;
            panelTerlambat.Controls.Add(labelTerlambat);
            panelTerlambat.Controls.Add(progressBarTerlambat);
            panelTerlambat.Location = new Point(771, 951);
            panelTerlambat.Name = "panelTerlambat";
            panelTerlambat.Size = new Size(582, 292);
            panelTerlambat.TabIndex = 17;
            // 
            // labelTerlambat
            // 
            labelTerlambat.AutoSize = true;
            labelTerlambat.ForeColor = Color.White;
            labelTerlambat.Location = new Point(57, 42);
            labelTerlambat.Name = "labelTerlambat";
            labelTerlambat.Size = new Size(176, 48);
            labelTerlambat.TabIndex = 2;
            labelTerlambat.Text = "Terlambat";
            // 
            // progressBarTerlambat
            // 
            progressBarTerlambat.ForeColor = Color.Transparent;
            progressBarTerlambat.Location = new Point(57, 164);
            progressBarTerlambat.Name = "progressBarTerlambat";
            progressBarTerlambat.Size = new Size(479, 69);
            progressBarTerlambat.TabIndex = 2;
            progressBarTerlambat.Value = 20;
            // 
            // panelTidakMasuk
            // 
            panelTidakMasuk.BackColor = Color.Crimson;
            panelTidakMasuk.Controls.Add(progressBarTIdakMasuk);
            panelTidakMasuk.Controls.Add(labelTidakMasuk);
            panelTidakMasuk.Location = new Point(1465, 951);
            panelTidakMasuk.Name = "panelTidakMasuk";
            panelTidakMasuk.Size = new Size(582, 292);
            panelTidakMasuk.TabIndex = 18;
            // 
            // progressBarTIdakMasuk
            // 
            progressBarTIdakMasuk.ForeColor = Color.Transparent;
            progressBarTIdakMasuk.Location = new Point(62, 164);
            progressBarTIdakMasuk.Name = "progressBarTIdakMasuk";
            progressBarTIdakMasuk.Size = new Size(479, 69);
            progressBarTIdakMasuk.TabIndex = 1;
            progressBarTIdakMasuk.Value = 20;
            // 
            // labelTidakMasuk
            // 
            labelTidakMasuk.AutoSize = true;
            labelTidakMasuk.ForeColor = Color.White;
            labelTidakMasuk.Location = new Point(62, 59);
            labelTidakMasuk.Name = "labelTidakMasuk";
            labelTidakMasuk.Size = new Size(218, 48);
            labelTidakMasuk.TabIndex = 0;
            labelTidakMasuk.Text = "Tidak Masuk";
            // 
            // dataGridViewRekap
            // 
            dataGridViewRekap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRekap.Location = new Point(84, 1303);
            dataGridViewRekap.Name = "dataGridViewRekap";
            dataGridViewRekap.RowHeadersWidth = 123;
            dataGridViewRekap.Size = new Size(1963, 363);
            dataGridViewRekap.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2132, 1739);
            Controls.Add(dataGridViewRekap);
            Controls.Add(panelTidakMasuk);
            Controls.Add(panelTerlambat);
            Controls.Add(panelTepatWaktu);
            Controls.Add(labelPMatkul);
            Controls.Add(labelMatkul);
            Controls.Add(labelTime);
            Controls.Add(labelTanggal);
            Controls.Add(labelKelas);
            Controls.Add(labelDosen);
            Controls.Add(pictureBoxPoint);
            Controls.Add(pictureBoxKalender);
            Controls.Add(pictureBoxProfil);
            Controls.Add(labelRekap);
            Controls.Add(labelDetailQRCode);
            Controls.Add(labelQRCode);
            Controls.Add(pictureBoxQRCode);
            Controls.Add(labelSelamatDatang);
            Controls.Add(labelRuangan);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKalender).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoint).EndInit();
            panelTepatWaktu.ResumeLayout(false);
            panelTepatWaktu.PerformLayout();
            panelTerlambat.ResumeLayout(false);
            panelTerlambat.PerformLayout();
            panelTidakMasuk.ResumeLayout(false);
            panelTidakMasuk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRekap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRuangan;
        private Label labelSelamatDatang;
        private PictureBox pictureBoxQRCode;
        private Label labelQRCode;
        private Label labelDetailQRCode;
        private Label labelRekap;
        private PictureBox pictureBoxProfil;
        private PictureBox pictureBoxKalender;
        private PictureBox pictureBoxPoint;
        private Label labelDosen;
        private Label labelKelas;
        private Label labelTime;
        private Label labelTanggal;
        private Label labelPMatkul;
        private Label labelMatkul;
        private Panel panelTepatWaktu;
        private Panel panelTerlambat;
        private Panel panelTidakMasuk;
        private ProgressBar progressBarTIdakMasuk;
        private Label labelTidakMasuk;
        private ProgressBar progressBarTepatWaktu;
        private ProgressBar progressBarTerlambat;
        private Label labelTepatWaktu;
        private Label labelTerlambat;
        private DataGridView dataGridViewRekap;
    }
}
