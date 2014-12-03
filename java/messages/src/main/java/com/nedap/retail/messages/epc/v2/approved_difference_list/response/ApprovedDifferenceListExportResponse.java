package com.nedap.retail.messages.epc.v2.approved_difference_list.response;

import java.util.ArrayList;
import java.util.List;

import org.apache.commons.collections.CollectionUtils;
import org.codehaus.jackson.map.annotate.JsonSerialize;

import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonInclude.Include;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.nedap.retail.messages.epc.v2.approved_difference_list.ApprovedDifferenceList;
import com.nedap.retail.messages.epc.v2.approved_difference_list.ApprovedDifferenceListSummary;
import com.nedap.retail.messages.epc.v2.approved_difference_list.GtinDifference;

@JsonInclude(Include.NON_NULL)
@JsonSerialize(include = JsonSerialize.Inclusion.NON_NULL)
public class ApprovedDifferenceListExportResponse extends ApprovedDifferenceListSummary {
    public List<String> gtins;
    @JsonProperty("approved_quantity")
    @org.codehaus.jackson.annotate.JsonProperty("approved_quantity")
    public List<Integer> approvedQuantity;

    public ApprovedDifferenceListExportResponse(final ApprovedDifferenceList approvedDifferenceList) {
        super(approvedDifferenceList.approvedDifferenceListSummary);

        gtins = new ArrayList<>();
        approvedQuantity = new ArrayList<>();
        if (!CollectionUtils.isEmpty(approvedDifferenceList.gtinDifferences)) {
            for (final GtinDifference gtinDifference : approvedDifferenceList.gtinDifferences) {
                gtins.add(gtinDifference.gtin);

                if (gtinDifference.approved) {
                    approvedQuantity.add(gtinDifference.rfidQuantity);
                } else {
                    approvedQuantity.add(gtinDifference.erpQuantity);
                }
            }
        }
    }
}