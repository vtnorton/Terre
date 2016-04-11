using Microsoft.Band;
using Microsoft.Band.Tiles;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace ProjectNice.Views
{
    public sealed partial class AddToBand : Page
    {
        public AddToBand()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            IBandInfo[] pairedBands = await BandClientManager.Instance.GetBandsAsync();
            if (pairedBands.Length < 1)
            {
                // "This sample app requires a Microsoft Band paired to your device. Also make sure that you have the latest firmware installed on your Band, as provided by the latest Microsoft Health app.";
                return;
            }
            try
            {
                using (IBandClient bandClient = await BandClientManager.Instance.ConnectAsync(pairedBands[0]))
                {
                    IEnumerable<BandTile> tiles = await bandClient.TileManager.GetTilesAsync();
                    int tileCapacity = await bandClient.TileManager.GetRemainingTileCapacityAsync();


                    WriteableBitmap smallIconBitmap = new WriteableBitmap(24, 24);
                    BandIcon smallIcon = smallIconBitmap.ToBandIcon();
                    WriteableBitmap tileIconBitmap = new WriteableBitmap(46, 46);
                    BandIcon tileIcon = tileIconBitmap.ToBandIcon();

                    Guid tileGuid = Guid.NewGuid();
                    BandTile tile = new BandTile(tileGuid)
                    {
                        IsBadgingEnabled = true,
                        Name = "TileName",
                        SmallIcon = smallIcon,
                        TileIcon = tileIcon
                    };
                    try
                    {
                        if (await bandClient.TileManager.AddTileAsync(tile))
                        {
                            // do work if the tile was successfully created    
                        }
                    }
                    catch (BandException ex)
                    {
                        // handle a Band connection exception 
                    }
                }
            }
            catch (BandException ex)
            {
                // handle a Band connection exception
            }
        }
    }
}
