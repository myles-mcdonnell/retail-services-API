package com.nedap.retail.messages.epc.v2.stock;

import org.codehaus.jackson.map.annotate.JsonSerialize;
import org.joda.time.DateTime;

import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonInclude.Include;
import com.fasterxml.jackson.annotation.JsonProperty;

@JsonInclude(Include.NON_NULL)
@JsonSerialize(include = JsonSerialize.Inclusion.NON_NULL)
public class StockLevelSummary {
    public DateTime generated;
    @JsonProperty("rfid_stock_time")
    @org.codehaus.jackson.annotate.JsonProperty("rfid_stock_time")
    public DateTime rfidStockTime;
    @JsonProperty("stock_rooms_quantity")
    @org.codehaus.jackson.annotate.JsonProperty("stock_rooms_quantity")
    public Integer stockRoomsQuantity;
    @JsonProperty("sales_floors_quantity")
    @org.codehaus.jackson.annotate.JsonProperty("sales_floors_quantity")
    public Integer salesFloorsQuantity;
    @JsonProperty("store_quantity")
    @org.codehaus.jackson.annotate.JsonProperty("store_quantity")
    public Integer storeQuantity;
    @JsonProperty("stock_ratio")
    @org.codehaus.jackson.annotate.JsonProperty("stock_ratio")
    public Double stockRatio;

    public StockLevelSummary() {
    }

    public StockLevelSummary(final DateTime generated, final DateTime rfidStockTime, final Integer stockRoomsQuantity,
            final Integer salesFloorsQuantity, final Integer storeQuantity, final Double stockRatio) {
        this.generated = generated;
        this.rfidStockTime = rfidStockTime;
        this.stockRoomsQuantity = stockRoomsQuantity;
        this.salesFloorsQuantity = salesFloorsQuantity;
        this.storeQuantity = storeQuantity;
        this.stockRatio = stockRatio;
    }
}