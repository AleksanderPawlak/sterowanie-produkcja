using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Wyznaczanie_Optymalnej_Trasy
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        private void InitializeDynamicMapButtons()
        {
            this.MapCarsButtons = new List<Button>();
            this.MapButtonsTableLayout.RowCount = resultAddressesNames.Count;
            this.MapButtonsTableLayout.RowStyles.Clear();
            for (int i = 0; i < resultAddressesNames.Count; i++)
            {
                int a = i;
                var button = new System.Windows.Forms.Button();
                button.Dock = System.Windows.Forms.DockStyle.Fill;
                button.Location = new System.Drawing.Point(0, 0);
                button.Name = "CarButton" + i.ToString();
                button.Size = new System.Drawing.Size(165, 82);
                button.TabIndex = i;
                button.Text = "Samochod nr " + (i + 1).ToString();
                button.UseVisualStyleBackColor = true;
                button.Click += (sender, e) => MapCarButton_Click(sender, e, a);
                this.MapCarsButtons.Add(button);

                this.MapButtonsTableLayout.Controls.Add(this.MapCarsButtons[i], 0, i);
                this.MapButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100/ (resultAddressesNames.Count + 1)));
            }
        }

        private void InitializeMap()
        {
            this.markersOverlay = new GMapOverlay("markers");
            this.routesOverlay = new GMapOverlay("routes");
            GMap.NET.MapProviders.GMapProviders.GoogleMap.ApiKey = Globals.API_KEY;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(
                Convert.ToDouble(AddressesNames[0].Coordinates.Latitude),
                Convert.ToDouble(AddressesNames[0].Coordinates.Longitude)
                );

            DrawMapRouteAndMarkers(0);
        }

        private void MapCarButton_Click(object sender, EventArgs e, int carNumber)
        {
                DrawMapRouteAndMarkers(carNumber);
        }

        private void DrawMapRouteAndMarkers(int carNumber)
        {
            // TODO: refactor
            try
            { 
                this.markersOverlay.Markers.Clear();
                this.routesOverlay.Routes.Clear();
                this.gMapControl1.Overlays.Clear();

                if (resultAddressesNames[carNumber].Count == 2) // XD Car without route
                    return;

                // Markers
                for (int i = 0; i < resultAddressesNames[carNumber].Count - 1; i++)
                {
                    var markerAddress = AddressesNames.Find(x => x.Name == resultAddressesNames[carNumber][i]);
                    GmapMarkerWithLabel marker = new GmapMarkerWithLabel(
                        new PointLatLng(Convert.ToDouble(markerAddress.Coordinates.Latitude),
                        Convert.ToDouble(markerAddress.Coordinates.Longitude)),
                        (i + 1).ToString(),
                        GMarkerGoogleType.green
                        );
                    this.markersOverlay.Markers.Add(marker);
                }

                // Routes
                List<PointLatLng> RoutePoints = new List<PointLatLng>();
                for (int i = 0; i < resultAddressesNames[carNumber].Count - 1; i++)
                {
                    var startAddress = AddressesNames.Find(x => x.Name == resultAddressesNames[carNumber][i]);
                    var endAddress = AddressesNames.Find(x => x.Name == resultAddressesNames[carNumber][i + 1]);
                    PointLatLng start = new GMap.NET.PointLatLng(
                        Convert.ToDouble(startAddress.Coordinates.Latitude),
                        Convert.ToDouble(startAddress.Coordinates.Longitude)
                        );
                    PointLatLng end = new GMap.NET.PointLatLng(
                        Convert.ToDouble(endAddress.Coordinates.Latitude),
                        Convert.ToDouble(endAddress.Coordinates.Longitude)
                    );
                    GDirections ss = null;
                    var xx = GMap.NET.MapProviders.GMapProviders.GoogleMap.GetDirections(
                        out ss, start, end, false, false, false, false, true
                        );

                    RoutePoints.AddRange(ss.Route);
                }

                GMapRoute route = new GMapRoute(RoutePoints, "My route");
                route.Stroke = new Pen(Color.Orange, 2);
                this.routesOverlay.Routes.Add(route);
                this.gMapControl1.Overlays.Add(routesOverlay);
                this.gMapControl1.Overlays.Add(markersOverlay);
            }
            catch (Exception drawingException)
            {
                // TODO: do something
                Console.WriteLine("Route drawing error");
            }
        }

        private void InitializeResultTable()
        {
            //TODO: refactor this ugly solution
            this.ResultListViewHeaders = new List<System.Windows.Forms.ColumnHeader>();
            //List<List<string>> resultAddressesNames = new List<List<string>>();
            int maxCarAddresses = 0;

            //split to columns
            int currentPosition = 0;
            for (int i = 0; i < Result.Car; i++)
            {
                int start = Array.IndexOf(Result.Road, 0, currentPosition);
                currentPosition = Array.IndexOf(Result.Road, 0, start + 1);
                List<string> carAddrssesNames = new List<string>();
                if ((currentPosition - start + 1) > maxCarAddresses)
                { maxCarAddresses = currentPosition - start + 1; }

                for (int j = start; j <= currentPosition; j++)
                {
                    int cityIndex = Result.Road[j];
                    carAddrssesNames.Add(AddressesNames[cityIndex].Name);
                }

                resultAddressesNames.Add(carAddrssesNames);
            }

            //initialize columns headers
            for (int i = 0; i < Result.Car; i++)
            {
                var header = new System.Windows.Forms.ColumnHeader();
                header.Text = "Samochód nr " + (i + 1).ToString();
                header.Width = 200;
                this.ResultListViewHeaders.Add(header);
                this.ResultListView.Columns.Add(header);
            }

            //assign data
            for (int i = 0; i < maxCarAddresses; i++)
            {
                List<string> row = new List<string>();

                for (int j = 0; j < Result.Car; j++)
                {
                    if (resultAddressesNames[j].Count == 2)
                    {
                        string info = i == 0 ? "Samochod nie powinien wyjezdzac" : "";
                        row.Add(info);
                    }
                    else
                    {
                        row.Add(resultAddressesNames[j].ElementAtOrDefault(i));
                    }
                }

                var listviewItem = new ListViewItem(row.ToArray());
                this.ResultListView.Items.Add(listviewItem);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultListView = new System.Windows.Forms.ListView();
            this.ResultTabControl = new System.Windows.Forms.TabControl();
            this.OrderTab = new System.Windows.Forms.TabPage();
            this.MapTab = new System.Windows.Forms.TabPage();
            this.MapTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.MapButtonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ResultTabControl.SuspendLayout();
            this.OrderTab.SuspendLayout();
            this.MapTab.SuspendLayout();
            this.MapTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultListView
            // 
            this.ResultListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultListView.HideSelection = false;
            this.ResultListView.Location = new System.Drawing.Point(3, 3);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(1616, 760);
            this.ResultListView.TabIndex = 0;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // ResultTabControl
            // 
            this.ResultTabControl.Controls.Add(this.OrderTab);
            this.ResultTabControl.Controls.Add(this.MapTab);
            this.ResultTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTabControl.Location = new System.Drawing.Point(0, 0);
            this.ResultTabControl.Name = "ResultTabControl";
            this.ResultTabControl.SelectedIndex = 0;
            this.ResultTabControl.Size = new System.Drawing.Size(1630, 810);
            this.ResultTabControl.TabIndex = 1;
            // 
            // OrderTab
            // 
            this.OrderTab.Controls.Add(this.ResultListView);
            this.OrderTab.Location = new System.Drawing.Point(4, 40);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTab.Size = new System.Drawing.Size(1622, 766);
            this.OrderTab.TabIndex = 0;
            this.OrderTab.Text = "Kolejność";
            this.OrderTab.UseVisualStyleBackColor = true;
            // 
            // MapTab
            // 
            this.MapTab.Controls.Add(this.MapTableLayoutPanel);
            this.MapTab.Location = new System.Drawing.Point(4, 40);
            this.MapTab.Name = "MapTab";
            this.MapTab.Padding = new System.Windows.Forms.Padding(3);
            this.MapTab.Size = new System.Drawing.Size(1622, 766);
            this.MapTab.TabIndex = 1;
            this.MapTab.Text = "Mapa";
            this.MapTab.UseVisualStyleBackColor = true;
            // 
            // MapTableLayoutPanel
            // 
            this.MapTableLayoutPanel.ColumnCount = 2;
            this.MapTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.10891F));
            this.MapTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.89109F));
            this.MapTableLayoutPanel.Controls.Add(this.gMapControl1, 0, 0);
            this.MapTableLayoutPanel.Controls.Add(this.MapButtonsTableLayout, 1, 0);
            this.MapTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.MapTableLayoutPanel.Name = "MapTableLayoutPanel";
            this.MapTableLayoutPanel.RowCount = 1;
            this.MapTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MapTableLayoutPanel.Size = new System.Drawing.Size(1616, 760);
            this.MapTableLayoutPanel.TabIndex = 1;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3, 3);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1433, 754);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 13D;
            // 
            // MapButtonsTableLayout
            // 
            this.MapButtonsTableLayout.ColumnCount = 1;
            this.MapButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MapButtonsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapButtonsTableLayout.Location = new System.Drawing.Point(1442, 3);
            this.MapButtonsTableLayout.Name = "MapButtonsTableLayout";
            this.MapButtonsTableLayout.RowCount = 1;
            this.MapButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MapButtonsTableLayout.Size = new System.Drawing.Size(171, 754);
            this.MapButtonsTableLayout.TabIndex = 1;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 810);
            this.Controls.Add(this.ResultTabControl);
            this.Name = "ResultForm";
            this.Text = "Wynik";
            this.ResultTabControl.ResumeLayout(false);
            this.OrderTab.ResumeLayout(false);
            this.MapTab.ResumeLayout(false);
            this.MapTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private ListView ResultListView;

        #endregion

        private List<System.Windows.Forms.ColumnHeader> ResultListViewHeaders;
        private TabControl ResultTabControl;
        private TabPage OrderTab;
        private TabPage MapTab;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private TableLayoutPanel MapTableLayoutPanel;
        private TableLayoutPanel MapButtonsTableLayout;
        private List<Button> MapCarsButtons;
        private GMapOverlay markersOverlay;
        private GMapOverlay routesOverlay;
    }
}