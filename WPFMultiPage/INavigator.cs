using System;
using System.Windows.Controls;

namespace WPFMultiPage
{
    interface INavigator
    {
        /// <summary>
        /// Fungsi untuk mengakses halaman yang ingin dibuka, 
        /// beserta dengan <i>state</i> dari aplikasi, jika terdapat
        /// state dalam aplikasi tersebut.
        /// 
        /// Contoh dari state misalnya: status autentikasi pengguna.
        /// </summary>
        /// <param name="nextPage">Objek Page untuk halaman selanjutnya.</param>
        /// <param name="state"><i>State</i> dari aplikasi yang ingin dikirimkan ke halaman selanjutnya.</param>
        void Navigate(Page nextPage, object state);

        /// <summary>
        /// Fungsi akses halaman lain, tanpa mengirimkan state.
        /// </summary>
        /// <param name="nextPage">Objek Page untuk halaman selanjutnya.</param>
        void Navigate(Page nextPage);
    }
}
